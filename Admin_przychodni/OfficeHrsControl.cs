using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Admin_przychodni
{

    public partial class OfficeHrsControl : UserControl
    {

        private string office;
        private string begin;
        private string end;
        private string doctor;
        private string date;
        private string name;
        private string surname;
        private string specialisation;
        private int doctorId;

        MySqlConnection conn = new MySqlConnection("datasource=sql7.freemysqlhosting.net;port=3306;username=sql7313340;password=EMvDjki61A");
        MySqlCommand command;
        MySqlDataReader reader;

        public OfficeHrsControl()
        {
            InitializeComponent();

            timePickerBegin.Format = DateTimePickerFormat.Custom;
            timePickerBegin.CustomFormat = "HH:mm";
            timePickerBegin.ShowUpDown = true;

            timePickerEnd.Format = DateTimePickerFormat.Custom;
            timePickerEnd.CustomFormat = "HH:mm";
            timePickerEnd.ShowUpDown = true;

            setButton.Hide();
        }

        private void OfficeHrsControl_Load(object sender, EventArgs e)
        {

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            errorMessage.Hide();
            if (isOfficeAvaliable() && isDoctorAvaliable())
            {
                AddOfficeHours();
                errorMessage.Show();
                errorMessage.Text = "Dodano dyzur pomyslnie";
                errorMessage.BackColor = Color.Green;
            }
            else
            {
                errorMessage.Show();
                errorMessage.BackColor = Color.Red;
                errorMessage.Text = "Blad";
                conn.Close();
            }
        }

        private bool isOfficeAvaliable()
        {
            getTextBoxes();

            conn.Open(); 
            string select = "SELECT Begin, End FROM sql7313340.Offices WHERE Office='" + office + "' AND (('" + begin + "' BETWEEN Begin AND End) OR ('" + end + "' BETWEEN Begin AND End)) AND DATE(Date)='" + date + "'";
            command = new MySqlCommand(select, conn);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return false;
            }
            else
            {
                reader.Close();
                conn.Close();
                return true;
            }
        }

        private bool isDoctorAvaliable()
        {
            getTextBoxes();

            conn.Open();
            string select = "SELECT Begin, End FROM(sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE a.Login='" + doctor + "' AND (('" + begin + "' BETWEEN o.Begin AND o.End) OR ('" + end + "' BETWEEN o.Begin AND o.End)) AND DATE(o.Date)='" + date + "'";
            command = new MySqlCommand(select, conn);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return false;
            }
            else
            {
                reader.Close();
                conn.Close();
                return true;
            }
        }

        private void AddOfficeHours()
        {
            getTextBoxes();

            conn.Open();
            string select = "SELECT d.Id FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account) WHERE a.Login='" + doctor + "'";
            command = new MySqlCommand(select, conn);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                doctorId = reader.GetInt32(0);
            }
            reader.Close();

            string insertOfficeHrs = "INSERT INTO sql7313340.Offices (Office, Date, Begin, End, Id_doctor) VALUES ('" + office + "','" + date + "','" + begin + "','" + end + "','" + doctorId + "')";
            command = new MySqlCommand(insertOfficeHrs, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void getTextBoxes()
        {
            office = officeTextBox.Text;
            begin = timePickerBegin.Value.TimeOfDay.Hours.ToString() + ":" + timePickerBegin.Value.TimeOfDay.Minutes.ToString() + ":00";
            end = timePickerEnd.Value.TimeOfDay.Hours.ToString() + ":" + timePickerEnd.Value.TimeOfDay.Minutes.ToString() + ":00";
            doctor = doctorTextBox.Text;
            date = datePicker.Value.Year.ToString() + "-" + datePicker.Value.Month.ToString() + "-" + datePicker.Value.Day.ToString();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            errorMessage.Hide();

            getTextBoxes();
            specialisation = specialization_TextBox.Text;
            name = fname_textBox.Text;
            surname = sname_textBox.Text;

            richTextBox1.Clear();

            if (Form1.isDoctor)
                doctor = Form1.login;

            conn.Open();
            string select = findWithFilters();
            if (select != " ")
            {
                command = new MySqlCommand(select, conn);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3).Split()[0] + ", " + reader.GetString(4).Split(':')[0] + ":" + reader.GetString(4).Split(':')[1] + "-" + reader.GetString(5).Split(':')[0] + ":" + reader.GetString(5).Split(':')[1] + ", " + reader.GetString(6) + "\n");
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                errorMessage.Show();
                errorMessage.BackColor = Color.Red;
                errorMessage.Text = "nie wybrano filtra";
                conn.Close();
            }
        }

        private string findWithFilters()
        {
            string select;

            if (office.Length != 0)
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE o.Office='" + office + "'";
            else if (doctor.Length != 0)
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE a.Login='" + doctor + "'";
            else if (begin != end)
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE o.Begin>='" + begin + "' AND o.End<='" + end + "'";
            else if(specialisation.Length != 0)
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE d.Specialization='" + specialisation + "'";
            else if(name.Length != 0)
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE d.FirstName='" + name + "'";
            else if (surname.Length != 0)
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE d.SecondName='" + surname + "'";
            else if (datePicker.CustomFormat == "dd/MM/yyyy")
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE DATE(o.Date)='" + date + "'";
            else
                select = " ";

            if(select!=" ")
            {
                if (office.Length != 0)
                    select += " AND o.Office='" + office + "'";
                if (doctor.Length != 0)
                    select += " AND a.Login='" + doctor + "'";
                if (begin != end)
                    select += "AND o.Begin >= '" + begin + "' AND o.End <= '" + end + "'";
                if (specialisation.Length != 0)
                    select += " AND d.Specialization='" + specialisation + "'";
                if (name.Length != 0)
                    select += " AND d.FirstName='" + name + "'";
                if (surname.Length != 0)
                    select += " AND d.SecondName='" + surname + "'";
                if (datePicker.CustomFormat == "dd/MM/yyyy")
                    select += " AND DATE(o.Date)='" + date + "'";
            }
            
            return select;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void timePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            timePickerBegin.Format = DateTimePickerFormat.Custom;
            timePickerBegin.CustomFormat = "HH:mm";
            timePickerBegin.ShowUpDown = true;
        }

        private void timePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            timePickerEnd.Format = DateTimePickerFormat.Custom;
            timePickerEnd.CustomFormat = "HH:mm";
            timePickerEnd.ShowUpDown = true;
        }

        public void showSetButton()
        {
            setButton.Show();
            infoLabel.Show();
            doctorLabel.Show();
            doctorTextBox.Show();
        }

        public void hideNonDoctorControlls()
        {
            fname_label.Hide();
            fname_textBox.Hide();
            sname_label.Hide();
            sname_textBox.Hide();
            specialization_Label.Hide();
            specialization_TextBox.Hide();
            doctorLabel.Hide();
            doctorTextBox.Hide();
        }

        public void showAllDoctorData()
        {
            richTextBox1.Clear();

            string select;

            select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor)";


            if (Form1.isDoctor)
            {
                doctor = Form1.login;
                select += " WHERE a.Login='" + Form1.login + "'";
            }

            conn.Open();
            
            command = new MySqlCommand(select, conn);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3).Split()[0] + ", " + reader.GetString(4).Split(':')[0] + ":" + reader.GetString(4).Split(':')[1] + "-" + reader.GetString(5).Split(':')[0] + ":" + reader.GetString(5).Split(':')[1] + ", " + reader.GetString(6) + "\n");
                }
            }

            reader.Close();
            conn.Close();
        }

        public void clearResults()
        {
            officeTextBox.Clear();
            doctorTextBox.Clear();
            fname_textBox.Clear();
            sname_textBox.Clear();
            specialization_TextBox.Clear();
            richTextBox1.Clear();
        }

    }
}

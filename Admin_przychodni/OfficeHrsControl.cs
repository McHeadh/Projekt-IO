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
        private int accountId;

        MySqlConnection conn = new MySqlConnection("datasource=sql7.freemysqlhosting.net;port=3306;username=sql7313340;password=EMvDjki61A");
        MySqlCommand command;
        MySqlDataReader reader;

        public OfficeHrsControl()
        {
            InitializeComponent();
            label1.Hide();
            //datePicker.Format = DateTimePickerFormat.Custom;
            //datePicker.CustomFormat = "dd/MM/yyyy";

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
            AddOfficeHours();
        }

        private void AddOfficeHours()
        {
            office = officeTextBox.Text;
            begin = timePickerBegin.Value.TimeOfDay.ToString();
            end = timePickerEnd.Value.TimeOfDay.ToString();
            doctor = doctorTextBox.Text;

            date = datePicker.Value.Year.ToString() + "-" + datePicker.Value.Month.ToString() + "-" + datePicker.Value.Day.ToString();


            FindLogin(doctor);
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

            label1.Text = begin; // checking manually if we found proper IdDoctor
            label1.Show();

            string insertOfficeHrs = "INSERT INTO sql7313340.Offices (Office, Date, Begin, End, Id_doctor) VALUES ('" + office + "','" + date + "','" + begin + "','" + end + "','" + doctorId + "')";
            command = new MySqlCommand(insertOfficeHrs, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }



        private bool FindLogin(string login)
        {
            string select = "SELECT Id FROM (sql7313340.Accounts) WHERE Login='" + login + "'";
            conn.Open();
            command = new MySqlCommand(select, conn);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                accountId = reader.GetInt32(0);
            }
            reader.Close();
            conn.Close();
            if (accountId != 0)
                return true;
            else
                return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            office = officeTextBox.Text;
            begin = timePickerBegin.Value.TimeOfDay.Hours.ToString() + ":" + timePickerBegin.Value.TimeOfDay.Minutes.ToString() + ":00";
            end = timePickerEnd.Value.TimeOfDay.Hours.ToString() + ":" + timePickerEnd.Value.TimeOfDay.Minutes.ToString() + ":00";
            doctor = doctorTextBox.Text;
            date = datePicker.Value.Year.ToString() + "/" + datePicker.Value.Month.ToString() + "/" + datePicker.Value.Day.ToString();
            specialisation = specialization_TextBox.Text;
            name = fname_textBox.Text;
            surname = sname_textBox.Text;

            richTextBox1.Clear();

            if (Form1.isDoctor)
                doctor = Form1.login;

            FindLogin(doctor);
            conn.Open();
            string select = findWithFilters(); //"SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE a.Login='" + doctor + "'";
            command = new MySqlCommand(select, conn);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3).Split()[0] + ", " + reader.GetString(4).Split(':')[0] + ":" + reader.GetString(4).Split(':')[1] + "-" + reader.GetString(5).Split(':')[0] + ":" + reader.GetString(5).Split(':')[1] + ", " + reader.GetString(6) + "\n");
                }
            }
            reader.Close();
            conn.Close();

            label2.Text = specialisation;

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
                select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE d.FirstName='" + surname + "'";
            //else if (datePicker.CustomFormat == "dd/MM/yyyy")
            //    select = "SELECT d.SecondName, d.FirstName, o.Office, o.Date, o.Begin, o.End, d.Specialization FROM (sql7313340.Accounts a JOIN sql7313340.Doctors d ON a.Id = d.Id_account JOIN sql7313340.Offices o ON d.Id = o.Id_doctor) WHERE o.Date='" + date + "'";
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
                //if (datePicker.CustomFormat == "dd/MM/yyyy")
                //    select = " ";
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
    }
}

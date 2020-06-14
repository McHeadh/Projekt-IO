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

namespace Admin_przychodni
{

    public partial class OfficeHrsControl : UserControl
    {

        private string office;
        private string begin;
        private string end;
        private string doctor;
        private string date;

        private int doctorId;
        private int accountId;

        MySqlConnection conn = new MySqlConnection("datasource=sql7.freemysqlhosting.net;port=3306;username=sql7313340;password=EMvDjki61A");
        MySqlCommand command;
        MySqlDataReader reader;

        public OfficeHrsControl()
        {
            InitializeComponent();
            label1.Hide();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void OfficeHrsControl_Load(object sender, EventArgs e)
        {

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            AddOfficeHours();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddOfficeHours()
        {
            office = officeTextBox.Text;
            begin = beginTextBox.Text;
            end = endTextBox.Text;
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

            label1.Text = doctorId.ToString(); // checking manually if we found proper IdDoctor
            label1.Show();

            //string insertOfficeHrs = "INSERT INTO sql7313340.Offices (Office, Date, Begin, End, Id_doctor) VALUES('" + office + "',('DATE: Manual Date','" + date + "'),'" + begin + "','" + end + "','" + doctorId + "')";
            //string insertOfficeHrs = "INSERT INTO sql7313340.Offices (Office, Date, Begin, End, Id_doctor) VALUES ('" + office + "',('DATE: Manual Date','" + date + "'),'16:00:00','18:00:00','" + doctorId + "')";
            //command = new MySqlCommand(insertOfficeHrs, conn);
            //command.ExecuteNonQuery();
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
    }
}

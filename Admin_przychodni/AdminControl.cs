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
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
            backButton.Hide();
            HideTextBoxes();
        }

        MySqlConnection conn = new MySqlConnection("datasource=sql7.freemysqlhosting.net;port=3306;username=sql7313340;password=EMvDjki61A");
        MySqlCommand command;
        MySqlDataReader reader;
        private bool isDoctor = false;
        private bool isReceptionist = false;
        private string fname;  // first name
        private string sname; // second name
        private string spec; // specialization
        private string login;
        private string password;
        private string function;
        private int accountId;

        private void AddDoctor()
        {
            fname = firstNameTextBox.Text;
            sname = secondNameTextBox.Text;
            login = setLoginTextBox.Text;
            password = setPasswordTextBox.Text;
            spec = specTextBox.Text;
            function = "Doctor";
            
            string insert2 = "INSERT INTO sql7313340.Accounts (Nick, Password, Function) VALUES('" + login + "','" + password + "','" + function + "')";
            string select = "SELECT Id FROM (sql7313340.Accounts) WHERE Nick='" + login + "'";
            
            conn.Open();
            command = new MySqlCommand(insert2, conn);
            command.ExecuteNonQuery();
            command = new MySqlCommand(select, conn);
            reader = command.ExecuteReader();
            reader.Read();
            accountId = reader.GetInt32(0);
            reader.Close();
            string insert1 = "INSERT INTO sql7313340.Doctors (FirstName, SecondName, Specialization, Id_account) VALUES('" + fname + "','" + sname + "','" + spec + "','" + accountId + "')";
            command = new MySqlCommand(insert1, conn);
            command.ExecuteNonQuery();
            conn.Close();
            ClearText();
        }

        private void ClearText()
        {
            setLoginTextBox.Clear();
            setPasswordTextBox.Clear();
            firstNameTextBox.Clear();
            secondNameTextBox.Clear();
            specTextBox.Clear();
        }

        private void HideTextBoxes()
        {
            setLoginLabel.Hide();
            setLoginTextBox.Hide();
            setPasswordLabel.Hide();
            setPasswordTextBox.Hide();
            firstNameLabel.Hide();
            firstNameTextBox.Hide();
            secondNameLabel.Hide();
            secondNameTextBox.Hide();
            specLabel.Hide();
            specTextBox.Hide();
            addButton.Hide();
            deleteButton.Hide();
        }

        private void ShowTextBoxes()
        {
            backButton.Show();
            firstNameLabel.Show();
            firstNameTextBox.Show();
            secondNameLabel.Show();
            secondNameTextBox.Show();
        }

        private void DoctorActrions()
        {
            isDoctor = true;
            Switch();
            specLabel.Show();
            specTextBox.Show();
        }

        private void ReceptionistActrions()
        {
            isReceptionist = true;
            Switch();
        }

        private void Switch()
        {
            HideButtons();
            ShowTextBoxes();
        }

        private void HideButtons()
        {
            addDoctor.Hide();
            deleteDoctor.Hide();
            addReceptionist.Hide();
            deleteReceptionist.Hide();
            logoutButton.Hide();
            backButton.Show();
        }

        private void ShowButtons()
        {
            addDoctor.Show();
            deleteDoctor.Show();
            addReceptionist.Show();
            deleteReceptionist.Show();
            logoutButton.Show();
            backButton.Show();
        }

        private void ShowSetLabels()
        {
            setLoginLabel.Show();
            setLoginTextBox.Show();
            setPasswordLabel.Show();
            setPasswordTextBox.Show();
        }

        private void addDoctor_Click(object sender, EventArgs e)
        {
            DoctorActrions();
            ShowSetLabels();
            addButton.Show();
        }

        private void deleteDoctor_Click(object sender, EventArgs e)
        {
            DoctorActrions();
            deleteButton.Show();
        }

        private void addReceptionist_Click(object sender, EventArgs e)
        {
            ReceptionistActrions();
            ShowSetLabels();
            addButton.Show();
        }

        private void deleteReceptionist_Click(object sender, EventArgs e)
        {
            ReceptionistActrions();
            deleteButton.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HideTextBoxes();
            ShowButtons();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddDoctor();
        }
    }
}

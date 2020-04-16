using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_przychodni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adminControlPanel.Hide();
            doctorControlPanel.Hide();
            receptionistControlPanel.Hide();
            LabelsHide();
        }

        MySqlConnection conn = new MySqlConnection("datasource=sql7.freemysqlhosting.net;port=3306;username=sql7313340;password=EMvDjki61A");
        public bool isAdministrator = false;
        public bool isDoctor = false;
        public bool isReceptionist = false;

        private void LabelsHide()
        {
            loginLabel.Hide();
            loginTextBox.Hide();
            passwordLabel.Hide();
            passwordTextBox.Hide();
            loginButton.Hide();
            errorLabel.Hide();
            backButton.Hide();
        }

        private void LabelsShow()
        {
            loginLabel.Show();
            loginTextBox.Show();
            passwordLabel.Show();
            passwordTextBox.Show();
            loginButton.Show();
            backButton.Show();
        }

        private void WelcomeHide()
        {
            welcomeLabel.Hide();
            adminButton.Hide();
            doctorButton.Hide();
            receptionistButton.Hide();
        }

        private void WelcomeShow()
        {
            welcomeLabel.Show();
            adminButton.Show();
            doctorButton.Show();
            receptionistButton.Show();
        }

        private void ClearTextBox()
        {
            loginTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            WelcomeHide();
            LabelsShow();
            isAdministrator = true;
        }

        private void doctorButton_Click(object sender, EventArgs e)
        {
            WelcomeHide();
            LabelsShow();
            isDoctor = true;
        }

        private void receptionistButton_Click(object sender, EventArgs e)
        {
            WelcomeHide();
            LabelsShow();
            isReceptionist = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomeShow();
            LabelsHide();
            ClearTextBox();
            isAdministrator = false;
            isDoctor = false;
            isReceptionist = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isAdministrator)
                Login("Administrator");
            if (isDoctor)
                Login("Doctor");
            if (isReceptionist)
                Login("Receptionist");
            ClearTextBox();
        }

        private void Login(string choice)
        {
            string select = "SELECT * FROM sql7313340.Accounts";
            conn.Open();
            MySqlCommand command = new MySqlCommand(select, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == loginTextBox.Text) // is login correct
                {
                    if (reader.GetString(2) == passwordTextBox.Text) // is password correct
                    {
                        if (choice == "Administrator" && reader.GetString(3) == "Administrator")
                            adminControlPanel.Show();
                        else if (choice == "Doctor" && reader.GetString(3) == "Doctor")
                            doctorControlPanel.Show();
                        else if (choice == "Receptionist" && reader.GetString(3) == "Receptionist")
                            receptionistControlPanel.Show();
                        else
                            errorLabel.Show();
                    }
                    else
                    {
                        errorLabel.Text = "Złe hasło!";
                        errorLabel.Show();
                    }
                    break;
                }
                else
                {
                    errorLabel.Text = "Nie ma takiego użytkownika!";
                    errorLabel.Show();
                }
            }
            reader.Close();
            conn.Close();
        }
    }
}

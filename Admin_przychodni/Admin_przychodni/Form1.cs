using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if(isAdministrator)
                adminControlPanel.Show();
            if (isDoctor)
                doctorControlPanel.Show();
            if (isReceptionist)
                receptionistControlPanel.Show();
            ClearTextBox();
        }
    }
}

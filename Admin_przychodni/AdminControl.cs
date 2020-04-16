using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private bool isDoctor = false;
        private bool isReceptionist = false;

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
    }
}

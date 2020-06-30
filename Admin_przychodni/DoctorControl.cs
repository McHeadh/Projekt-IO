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
    public partial class DoctorControl : UserControl
    {
        public DoctorControl()
        {
            InitializeComponent();

            officeHrsControl1.hideNonDoctorControlls();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            officeHrsControl1.clearResults();
        }

        public void Inicialization()
        {
            officeHrsControl1.showAllDoctorData();
        }

        private void officeHrsControl1_Load(object sender, EventArgs e)
        {
            officeHrsControl1.showAllDoctorData();
        }
    }
}

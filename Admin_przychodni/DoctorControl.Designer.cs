﻿namespace Admin_przychodni
{
    partial class DoctorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoutButton = new System.Windows.Forms.Button();
            this.officeHrsControl1 = new Admin_przychodni.OfficeHrsControl();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(3, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 25);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "<- Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // officeHrsControl1
            // 
            this.officeHrsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.officeHrsControl1.Location = new System.Drawing.Point(0, 0);
            this.officeHrsControl1.Name = "officeHrsControl1";
            this.officeHrsControl1.Size = new System.Drawing.Size(624, 380);
            this.officeHrsControl1.TabIndex = 1;
            // 
            // DoctorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.officeHrsControl1);
            this.Name = "DoctorControl";
            this.Size = new System.Drawing.Size(624, 380);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private OfficeHrsControl officeHrsControl1;
    }
}

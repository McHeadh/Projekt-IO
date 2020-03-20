namespace Admin_przychodni
{
    partial class AdminControl
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
            this.addDoctor = new System.Windows.Forms.Button();
            this.deleteDoctor = new System.Windows.Forms.Button();
            this.addReceptionist = new System.Windows.Forms.Button();
            this.deleteReceptionist = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(3, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 25);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "<- Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // addDoctor
            // 
            this.addDoctor.Location = new System.Drawing.Point(183, 98);
            this.addDoctor.Name = "addDoctor";
            this.addDoctor.Size = new System.Drawing.Size(150, 47);
            this.addDoctor.TabIndex = 1;
            this.addDoctor.Text = "Zarejestruj lekarza";
            this.addDoctor.UseVisualStyleBackColor = true;
            this.addDoctor.Click += new System.EventHandler(this.addDoctor_Click);
            // 
            // deleteDoctor
            // 
            this.deleteDoctor.Location = new System.Drawing.Point(183, 151);
            this.deleteDoctor.Name = "deleteDoctor";
            this.deleteDoctor.Size = new System.Drawing.Size(150, 47);
            this.deleteDoctor.TabIndex = 2;
            this.deleteDoctor.Text = "Usuń lekarza";
            this.deleteDoctor.UseVisualStyleBackColor = true;
            this.deleteDoctor.Click += new System.EventHandler(this.deleteDoctor_Click);
            // 
            // addReceptionist
            // 
            this.addReceptionist.Location = new System.Drawing.Point(183, 204);
            this.addReceptionist.Name = "addReceptionist";
            this.addReceptionist.Size = new System.Drawing.Size(150, 47);
            this.addReceptionist.TabIndex = 3;
            this.addReceptionist.Text = "Zarejestruj recepcjonistę";
            this.addReceptionist.UseVisualStyleBackColor = true;
            this.addReceptionist.Click += new System.EventHandler(this.addReceptionist_Click);
            // 
            // deleteReceptionist
            // 
            this.deleteReceptionist.Location = new System.Drawing.Point(182, 257);
            this.deleteReceptionist.Name = "deleteReceptionist";
            this.deleteReceptionist.Size = new System.Drawing.Size(150, 47);
            this.deleteReceptionist.TabIndex = 4;
            this.deleteReceptionist.Text = "Usuń recepcjonistę";
            this.deleteReceptionist.UseVisualStyleBackColor = true;
            this.deleteReceptionist.Click += new System.EventHandler(this.deleteReceptionist_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(183, 112);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(180, 96);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "Imię:";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(179, 135);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(56, 13);
            this.secondNameLabel.TabIndex = 7;
            this.secondNameLabel.Text = "Nazwisko:";
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(183, 154);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.secondNameTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(263, 180);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 47);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Zarejestruj";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(183, 180);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 47);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 25);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "<- Powrót";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteReceptionist);
            this.Controls.Add(this.addReceptionist);
            this.Controls.Add(this.deleteDoctor);
            this.Controls.Add(this.addDoctor);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.backButton);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(556, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button addDoctor;
        private System.Windows.Forms.Button deleteDoctor;
        private System.Windows.Forms.Button addReceptionist;
        private System.Windows.Forms.Button deleteReceptionist;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}

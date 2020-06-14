namespace Admin_przychodni
{
    partial class OfficeHrsControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.officeLabel = new System.Windows.Forms.Label();
            this.officeTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.beginLabel = new System.Windows.Forms.Label();
            this.beginTextBox = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(56, 57);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(44, 13);
            this.officeLabel.TabIndex = 0;
            this.officeLabel.Text = "Gabinet";
            // 
            // officeTextBox
            // 
            this.officeTextBox.Location = new System.Drawing.Point(59, 74);
            this.officeTextBox.Name = "officeTextBox";
            this.officeTextBox.Size = new System.Drawing.Size(100, 20);
            this.officeTextBox.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(249, 57);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Data:";
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Location = new System.Drawing.Point(423, 57);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(66, 13);
            this.beginLabel.TabIndex = 3;
            this.beginLabel.Text = "Godzina Od:";
            // 
            // beginTextBox
            // 
            this.beginTextBox.Location = new System.Drawing.Point(426, 74);
            this.beginTextBox.Name = "beginTextBox";
            this.beginTextBox.Size = new System.Drawing.Size(100, 20);
            this.beginTextBox.TabIndex = 5;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(570, 57);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(66, 13);
            this.endLabel.TabIndex = 6;
            this.endLabel.Text = "Godzina Do:";
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(573, 73);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(100, 20);
            this.endTextBox.TabIndex = 7;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(188, 73);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 8;
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(64, 154);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(42, 13);
            this.doctorLabel.TabIndex = 9;
            this.doctorLabel.Text = "Lekarz:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(67, 170);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorTextBox.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Wstecz";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(313, 285);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 12;
            this.setButton.Text = "Dodaj";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OfficeHrsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.beginTextBox);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.officeTextBox);
            this.Controls.Add(this.officeLabel);
            this.Name = "OfficeHrsControl";
            this.Size = new System.Drawing.Size(685, 431);
            this.Load += new System.EventHandler(this.OfficeHrsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.TextBox officeTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label beginLabel;
        private System.Windows.Forms.TextBox beginTextBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label label1;
    }
}

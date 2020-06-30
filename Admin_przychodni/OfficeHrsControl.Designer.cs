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
            this.endLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.timePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.timePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.fname_textBox = new System.Windows.Forms.TextBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.sname_label = new System.Windows.Forms.Label();
            this.sname_textBox = new System.Windows.Forms.TextBox();
            this.specialization_Label = new System.Windows.Forms.Label();
            this.specialization_TextBox = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(35, 57);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(47, 13);
            this.officeLabel.TabIndex = 0;
            this.officeLabel.Text = "Gabinet:";
            // 
            // officeTextBox
            // 
            this.officeTextBox.Location = new System.Drawing.Point(38, 73);
            this.officeTextBox.Name = "officeTextBox";
            this.officeTextBox.Size = new System.Drawing.Size(41, 20);
            this.officeTextBox.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(85, 57);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Data:";
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Location = new System.Drawing.Point(189, 57);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(66, 13);
            this.beginLabel.TabIndex = 3;
            this.beginLabel.Text = "Godzina Od:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(282, 57);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(66, 13);
            this.endLabel.TabIndex = 6;
            this.endLabel.Text = "Godzina Do:";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = " ";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(88, 73);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(95, 20);
            this.datePicker.TabIndex = 8;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(372, 57);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(42, 13);
            this.doctorLabel.TabIndex = 9;
            this.doctorLabel.Text = "Lekarz:";
            this.doctorLabel.Visible = false;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(375, 73);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorTextBox.TabIndex = 10;
            this.doctorTextBox.Visible = false;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(478, 71);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 12;
            this.setButton.Text = "Dodaj";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // timePickerBegin
            // 
            this.timePickerBegin.CustomFormat = " ";
            this.timePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerBegin.Location = new System.Drawing.Point(192, 73);
            this.timePickerBegin.Name = "timePickerBegin";
            this.timePickerBegin.Size = new System.Drawing.Size(84, 20);
            this.timePickerBegin.TabIndex = 14;
            this.timePickerBegin.ValueChanged += new System.EventHandler(this.timePickerBegin_ValueChanged);
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.CustomFormat = " ";
            this.timePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerEnd.Location = new System.Drawing.Point(285, 73);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.Size = new System.Drawing.Size(84, 20);
            this.timePickerEnd.TabIndex = 15;
            this.timePickerEnd.ValueChanged += new System.EventHandler(this.timePickerEnd_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(483, 238);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(478, 42);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 17;
            this.filterButton.Text = "Filtruj";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // fname_textBox
            // 
            this.fname_textBox.Location = new System.Drawing.Point(192, 34);
            this.fname_textBox.Name = "fname_textBox";
            this.fname_textBox.Size = new System.Drawing.Size(84, 20);
            this.fname_textBox.TabIndex = 19;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(189, 18);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(29, 13);
            this.fname_label.TabIndex = 20;
            this.fname_label.Text = "Imie:";
            // 
            // sname_label
            // 
            this.sname_label.AutoSize = true;
            this.sname_label.Location = new System.Drawing.Point(282, 18);
            this.sname_label.Name = "sname_label";
            this.sname_label.Size = new System.Drawing.Size(56, 13);
            this.sname_label.TabIndex = 21;
            this.sname_label.Text = "Nazwisko:";
            // 
            // sname_textBox
            // 
            this.sname_textBox.Location = new System.Drawing.Point(285, 34);
            this.sname_textBox.Name = "sname_textBox";
            this.sname_textBox.Size = new System.Drawing.Size(84, 20);
            this.sname_textBox.TabIndex = 22;
            // 
            // specialization_Label
            // 
            this.specialization_Label.AutoSize = true;
            this.specialization_Label.Location = new System.Drawing.Point(372, 18);
            this.specialization_Label.Name = "specialization_Label";
            this.specialization_Label.Size = new System.Drawing.Size(72, 13);
            this.specialization_Label.TabIndex = 23;
            this.specialization_Label.Text = "Specializacja:";
            // 
            // specialization_TextBox
            // 
            this.specialization_TextBox.Location = new System.Drawing.Point(375, 34);
            this.specialization_TextBox.Name = "specialization_TextBox";
            this.specialization_TextBox.Size = new System.Drawing.Size(80, 20);
            this.specialization_TextBox.TabIndex = 24;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.BackColor = System.Drawing.Color.Maroon;
            this.errorMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.errorMessage.Location = new System.Drawing.Point(35, 97);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(151, 13);
            this.errorMessage.TabIndex = 25;
            this.errorMessage.Text = "Termin lub gabinet nietostepny";
            this.errorMessage.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(62, 34);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(121, 13);
            this.infoLabel.TabIndex = 26;
            this.infoLabel.Text = "Pola tylko do filtrowania:";
            this.infoLabel.Visible = false;
            // 
            // OfficeHrsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.specialization_TextBox);
            this.Controls.Add(this.specialization_Label);
            this.Controls.Add(this.sname_textBox);
            this.Controls.Add(this.sname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.fname_textBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.timePickerEnd);
            this.Controls.Add(this.timePickerBegin);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.officeTextBox);
            this.Controls.Add(this.officeLabel);
            this.Name = "OfficeHrsControl";
            this.Size = new System.Drawing.Size(556, 381);
            this.Load += new System.EventHandler(this.OfficeHrsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.TextBox officeTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label beginLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.DateTimePicker timePickerBegin;
        private System.Windows.Forms.DateTimePicker timePickerEnd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox fname_textBox;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label sname_label;
        private System.Windows.Forms.TextBox sname_textBox;
        private System.Windows.Forms.Label specialization_Label;
        private System.Windows.Forms.TextBox specialization_TextBox;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label infoLabel;
    }
}

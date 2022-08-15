namespace hill_CourseProject_Part2
{
    partial class InputForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BenefitsGroupBox = new System.Windows.Forms.GroupBox();
            this.VacationTextBox = new System.Windows.Forms.TextBox();
            this.VacationLabel = new System.Windows.Forms.Label();
            this.LifeInsTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsLabel = new System.Windows.Forms.Label();
            this.HealthInsTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsLabel = new System.Windows.Forms.Label();
            this.HourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.PayOneTextBox = new System.Windows.Forms.TextBox();
            this.PayOneLabel = new System.Windows.Forms.Label();
            this.PayTwoTextBox = new System.Windows.Forms.TextBox();
            this.PayTwoLabel = new System.Windows.Forms.Label();
            this.BenefitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(54, 111);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(155, 31);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(319, 111);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(382, 38);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(319, 155);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(382, 38);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(54, 155);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(153, 31);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(319, 199);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(382, 38);
            this.SSNTextBox.TabIndex = 4;
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(54, 199);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(78, 31);
            this.SSNLabel.TabIndex = 4;
            this.SSNLabel.Text = "SSN:";
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(319, 243);
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(382, 38);
            this.HireDateTextBox.TabIndex = 5;
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(54, 243);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(137, 31);
            this.HireDateLabel.TabIndex = 6;
            this.HireDateLabel.Text = "Hire Date:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Location = new System.Drawing.Point(145, 621);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(258, 68);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(435, 621);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(288, 68);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BenefitsGroupBox
            // 
            this.BenefitsGroupBox.Controls.Add(this.VacationTextBox);
            this.BenefitsGroupBox.Controls.Add(this.VacationLabel);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsTextBox);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsLabel);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsTextBox);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsLabel);
            this.BenefitsGroupBox.Location = new System.Drawing.Point(60, 383);
            this.BenefitsGroupBox.Name = "BenefitsGroupBox";
            this.BenefitsGroupBox.Size = new System.Drawing.Size(749, 219);
            this.BenefitsGroupBox.TabIndex = 8;
            this.BenefitsGroupBox.TabStop = false;
            this.BenefitsGroupBox.Text = "Benefits";
            // 
            // VacationTextBox
            // 
            this.VacationTextBox.Location = new System.Drawing.Point(269, 156);
            this.VacationTextBox.Name = "VacationTextBox";
            this.VacationTextBox.Size = new System.Drawing.Size(446, 38);
            this.VacationTextBox.TabIndex = 2;
            // 
            // VacationLabel
            // 
            this.VacationLabel.AutoSize = true;
            this.VacationLabel.Location = new System.Drawing.Point(35, 156);
            this.VacationLabel.Name = "VacationLabel";
            this.VacationLabel.Size = new System.Drawing.Size(198, 31);
            this.VacationLabel.TabIndex = 6;
            this.VacationLabel.Text = "Vacation Days:";
            // 
            // LifeInsTextBox
            // 
            this.LifeInsTextBox.Location = new System.Drawing.Point(269, 106);
            this.LifeInsTextBox.Name = "LifeInsTextBox";
            this.LifeInsTextBox.Size = new System.Drawing.Size(446, 38);
            this.LifeInsTextBox.TabIndex = 1;
            // 
            // LifeInsLabel
            // 
            this.LifeInsLabel.AutoSize = true;
            this.LifeInsLabel.Location = new System.Drawing.Point(35, 106);
            this.LifeInsLabel.Name = "LifeInsLabel";
            this.LifeInsLabel.Size = new System.Drawing.Size(193, 31);
            this.LifeInsLabel.TabIndex = 4;
            this.LifeInsLabel.Text = "Life Insurance:";
            // 
            // HealthInsTextBox
            // 
            this.HealthInsTextBox.Location = new System.Drawing.Point(269, 56);
            this.HealthInsTextBox.Name = "HealthInsTextBox";
            this.HealthInsTextBox.Size = new System.Drawing.Size(446, 38);
            this.HealthInsTextBox.TabIndex = 0;
            // 
            // HealthInsLabel
            // 
            this.HealthInsLabel.AutoSize = true;
            this.HealthInsLabel.Location = new System.Drawing.Point(35, 56);
            this.HealthInsLabel.Name = "HealthInsLabel";
            this.HealthInsLabel.Size = new System.Drawing.Size(228, 31);
            this.HealthInsLabel.TabIndex = 2;
            this.HealthInsLabel.Text = "Health Insurance:";
            // 
            // HourlyRadioButton
            // 
            this.HourlyRadioButton.AutoSize = true;
            this.HourlyRadioButton.Location = new System.Drawing.Point(304, 30);
            this.HourlyRadioButton.Name = "HourlyRadioButton";
            this.HourlyRadioButton.Size = new System.Drawing.Size(111, 35);
            this.HourlyRadioButton.TabIndex = 0;
            this.HourlyRadioButton.TabStop = true;
            this.HourlyRadioButton.Text = "Hourly";
            this.HourlyRadioButton.UseVisualStyleBackColor = true;
            this.HourlyRadioButton.CheckedChanged += new System.EventHandler(this.HourlyRadioButton_CheckedChanged);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(456, 30);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(109, 35);
            this.SalaryRadioButton.TabIndex = 1;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // PayOneTextBox
            // 
            this.PayOneTextBox.Location = new System.Drawing.Point(319, 287);
            this.PayOneTextBox.Name = "PayOneTextBox";
            this.PayOneTextBox.Size = new System.Drawing.Size(382, 38);
            this.PayOneTextBox.TabIndex = 6;
            // 
            // PayOneLabel
            // 
            this.PayOneLabel.AutoSize = true;
            this.PayOneLabel.Location = new System.Drawing.Point(54, 287);
            this.PayOneLabel.Name = "PayOneLabel";
            this.PayOneLabel.Size = new System.Drawing.Size(166, 31);
            this.PayOneLabel.TabIndex = 13;
            this.PayOneLabel.Text = "Hourly Rate:";
            // 
            // PayTwoTextBox
            // 
            this.PayTwoTextBox.Location = new System.Drawing.Point(319, 331);
            this.PayTwoTextBox.Name = "PayTwoTextBox";
            this.PayTwoTextBox.Size = new System.Drawing.Size(382, 38);
            this.PayTwoTextBox.TabIndex = 7;
            // 
            // PayTwoLabel
            // 
            this.PayTwoLabel.AutoSize = true;
            this.PayTwoLabel.Location = new System.Drawing.Point(54, 331);
            this.PayTwoLabel.Name = "PayTwoLabel";
            this.PayTwoLabel.Size = new System.Drawing.Size(195, 31);
            this.PayTwoLabel.TabIndex = 15;
            this.PayTwoLabel.Text = "Hours Worked:";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 709);
            this.Controls.Add(this.PayTwoTextBox);
            this.Controls.Add(this.PayTwoLabel);
            this.Controls.Add(this.PayOneTextBox);
            this.Controls.Add(this.PayOneLabel);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.HourlyRadioButton);
            this.Controls.Add(this.BenefitsGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.HireDateLabel);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.BenefitsGroupBox.ResumeLayout(false);
            this.BenefitsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label HireDateLabel;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox SSNTextBox;
        public System.Windows.Forms.TextBox HireDateTextBox;
        private System.Windows.Forms.GroupBox BenefitsGroupBox;
        public System.Windows.Forms.TextBox VacationTextBox;
        private System.Windows.Forms.Label VacationLabel;
        public System.Windows.Forms.TextBox LifeInsTextBox;
        private System.Windows.Forms.Label LifeInsLabel;
        public System.Windows.Forms.TextBox HealthInsTextBox;
        private System.Windows.Forms.Label HealthInsLabel;
        public System.Windows.Forms.Button SubmitButton;
        public System.Windows.Forms.TextBox PayOneTextBox;
        private System.Windows.Forms.Label PayOneLabel;
        public System.Windows.Forms.TextBox PayTwoTextBox;
        private System.Windows.Forms.Label PayTwoLabel;
        public System.Windows.Forms.RadioButton HourlyRadioButton;
        public System.Windows.Forms.RadioButton SalaryRadioButton;
    }
}
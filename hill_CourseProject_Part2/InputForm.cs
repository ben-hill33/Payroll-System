using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hill_CourseProject_Part2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void HourlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowControls();
        }



        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowControls();
        }
        
        private void ShowControls()
        {
            // show appropriate controls
            if (HourlyRadioButton.Checked)
            {
                PayOneLabel.Text = "Hourly Rate: ";
                PayTwoLabel.Text = "Hours Worked: ";
                PayTwoLabel.Visible = true;
                PayTwoTextBox.Visible = true;
            }
            else if (SalaryRadioButton.Checked)
            {
                PayOneLabel.Text = "Annual Salary: ";
                PayTwoLabel.Visible = false;
                PayTwoTextBox.Visible = false;
            }
        }
    }
}

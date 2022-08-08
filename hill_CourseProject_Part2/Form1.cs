using System;
using System.Windows.Forms;

namespace hill_CourseProject_Part2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Add item to employee listbox.
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // Check if input form was cancelled.
                if (result == DialogResult.Cancel)
                    return; // If yes, cancel input.

                // Get user input and create new Employee object.
                string fstName = frmInput.FirstNameTextBox.Text;
                string lstName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);

                Employee emp = new Employee(fstName, lstName, ssn, hireDate);

                // Add Employee object to employee listbox
                EmployeesListBox.Items.Add(emp);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // remove selected index from employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying all employees");
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }
    }
}

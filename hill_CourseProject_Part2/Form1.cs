using System;
using System.IO;
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
                string healthIns = frmInput.HealthInsTextBox.Text;
                double lifeIns = Double.Parse(frmInput.LifeInsTextBox.Text);
                int vacation = Int32.Parse(frmInput.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                Employee emp = new Employee(fstName, lstName, ssn, hireDate, benefits);

                // Add Employee object to employee listbox
                EmployeesListBox.Items.Add(emp);

                // write all Employee objects to the file
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            // Write Employee objects to the file
            string fileName = "Employees.csv";
            StreamWriter streamW = new StreamWriter(fileName);
            for (int i = 0; i < EmployeesListBox.Items.Count; i++)
            {
                Employee tempEmp = (Employee)EmployeesListBox.Items[i];

                streamW.WriteLine($"{tempEmp.FirstName},{tempEmp.LastName},{tempEmp.SSN}," +
                    $"{tempEmp.HireDate.ToShortDateString()}, {tempEmp.BenefitsPackage.HealthInsurance}," +
                    $"{tempEmp.BenefitsPackage.LifeInsurance}, {tempEmp.BenefitsPackage.Vacation}");
            }

            streamW.Close();

            // tell user that records were written to file
            MessageBox.Show("Employees were written to the file.");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // remove selected index from employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);

                // write all Employee objects to the file
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // Clear listbox
            EmployeesListBox.Items.Clear();

            // read all Employee objects from the file
            ReadEmpsFromFile();
        }

        private void ReadEmpsFromFile()
        {
            // Read all Employee object from the file
            string fileName = "Employees.csv";

            StreamReader streamR = new StreamReader(fileName);

            using (streamR)
            {
                while (streamR.Peek() > -1)
                {
                    // Read line and break it into pieces by commas
                    string line = streamR.ReadLine();
                    string[] parts = line.Split(',');

                    string fstName = parts[0];
                    string lstName = parts[1];
                    string ssn = parts[2];
                    DateTime hireDate = DateTime.Parse(parts[3]);
                    string healthIns = parts[4];
                    double lifeIns = Double.Parse(parts[5]);
                    int vacation = Int32.Parse(parts[6]);

                    // Create employee object and add it to listbox
                    Employee emp = new Employee(fstName, lstName, ssn, 
                        hireDate, new Benefits(healthIns, lifeIns, vacation));
                    EmployeesListBox.Items.Add(emp);
                }
            }
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }
    }
}

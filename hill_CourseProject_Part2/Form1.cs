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
                Employee emp;

                if (frmInput.HourlyRadioButton.Checked)
                {
                    // get child items
                    float hourlyRate = float.Parse(frmInput.PayOneTextBox.Text);
                    float hoursWorked = Convert.ToSingle(frmInput.PayTwoTextBox.Text);

                    // Polymorphism -- poly - many; morph - change into
                    // Parent Employee becomes new child object Hourly
                    emp = new Hourly(fstName, lstName, ssn, hireDate, benefits, hourlyRate, hoursWorked);
                }
                else if (frmInput.SalaryRadioButton.Checked)
                {
                    // get child items
                    double salary = Convert.ToDouble(frmInput.PayOneTextBox.Text);

                    // Polymorphism
                    emp = new Salary(fstName, lstName, ssn, hireDate, benefits, salary);
                }
                else
                {
                    MessageBox.Show("Error. Invalid Employee Type.");
                    return; // end method if error.
                }

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

        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            // Edit selected employee in the listbox
            InputForm frmUpdate = new InputForm();

            using (frmUpdate)
            {
                frmUpdate.Text = "Employee Update Form";
                frmUpdate.SubmitButton.Text = "Update";

                int itemNumber = EmployeesListBox.SelectedIndex;

                if(itemNumber < 0)
                {
                    MessageBox.Show("Error. Invalid Employee.");
                    return;
                }
                Employee emp = (Employee)EmployeesListBox.Items[itemNumber];

                frmUpdate.FirstNameTextBox.Text = emp.FirstName;
                frmUpdate.LastNameTextBox.Text = emp.LastName;
                frmUpdate.SSNTextBox.Text = emp.SSN;
                frmUpdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
                frmUpdate.HealthInsTextBox.Text = emp.BenefitsPackage.HealthInsurance;
                frmUpdate.LifeInsTextBox.Text = emp.BenefitsPackage.LifeInsurance.ToString("C2");
                frmUpdate.VacationTextBox.Text = emp.BenefitsPackage.Vacation.ToString();

                DialogResult result = frmUpdate.ShowDialog();

                if(result == DialogResult.Cancel)
                {
                    return; // end method since user cancelled update.
                }

                EmployeesListBox.Items.RemoveAt(itemNumber);

                // Get user's updated input and create an Employee object.
                string fName = frmUpdate.FirstNameTextBox.Text;
                string lName = frmUpdate.LastNameTextBox.Text;
                string ssn = frmUpdate.SSNTextBox.Text;
                string date = frmUpdate.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmUpdate.HealthInsTextBox.Text;
                // pull a substring that does not contain the initial '$' sign
                string lifeInsString = frmUpdate.LifeInsTextBox.Text;
                lifeInsString = lifeInsString.Substring(1);
                double lifeIns = Double.Parse(lifeInsString);
                int vacationDays = Int32.Parse(frmUpdate.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacationDays);
                emp = new Employee(fName, lName, ssn, hireDate, benefits);

                // Add the updated Employee object to the employees listbox.
                EmployeesListBox.Items.Add(emp);

                // Write all the updated Employee objects to the file
                WriteEmpsToFile();
            }
        }
    }
}

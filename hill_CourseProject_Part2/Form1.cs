using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; // translates binary
using System.Windows.Forms;

namespace hill_CourseProject_Part2
{
    public partial class MainForm : Form
    {
        // Form level references
        const string FILENAME = "Employees.dat";

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
            // Convert listbox items to a generic list.
            List<Employee> empList = new List<Employee>();

            foreach (Employee emp in EmployeesListBox.Items)
            {
                empList.Add(emp);
            }

            // Open pipe to the file and create a translator.
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            // Write generic list to the file.
            formatter.Serialize(fs, empList);

            // Close pipe.
            fs.Close();

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
            // Check to see if file exists.
            if (File.Exists(FILENAME) && new FileInfo(FILENAME).Length > 0)
            {
                // Create pipe from the file and create the translator
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                // Read Employee objects from the file.
                List<Employee> empList = (List<Employee>)formatter.Deserialize(fs);

                // Close the pipe.
                fs.Close();

                // Copy the Employee objects into listbox
                foreach(Employee emp in empList)
                {
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

                if(emp is Hourly)
                {
                    Hourly hourly = (Hourly)emp;
                    frmUpdate.HourlyRadioButton.Checked = true;
                    frmUpdate.PayOneTextBox.Text = hourly.HourlyRate.ToString("N2");
                    frmUpdate.PayTwoTextBox.Text = hourly.HoursWorked.ToString("F1");
                }
                else if(emp is Salary)
                {
                    Salary sal = (Salary)emp;
                    frmUpdate.SalaryRadioButton.Checked = true;
                    frmUpdate.PayOneTextBox.Text = sal.AnnualSalary.ToString("N2");
                }

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

                if (frmUpdate.HourlyRadioButton.Checked)
                {
                    float rate = float.Parse(frmUpdate.PayOneTextBox.Text);
                    float hours = float.Parse(frmUpdate.PayTwoTextBox.Text);
                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, rate, hours);
                }
                else if (frmUpdate.SalaryRadioButton.Checked)
                {
                    double salary = Double.Parse(frmUpdate.PayOneTextBox.Text);
                    emp = new Salary(fName, lName, ssn, hireDate, benefits, salary);
                }

                // Add the updated Employee object to the employees listbox.
                EmployeesListBox.Items.Add(emp);

                // Write all the updated Employee objects to the file
                WriteEmpsToFile();
            }
        }
    }
}

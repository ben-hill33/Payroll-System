using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hill_CourseProject_Part2
{
    class Employee
    {
        // attributes
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;
        private Benefits benefits;

        // constructors
        public Employee()
        {
            firstName = "unknown";
            lastName = "unknown";
            ssn = "unknown";
            hireDate = DateTime.MinValue;
        }

        public Employee(string firstName, string lastName, string ssn, DateTime hireDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            SSN = ssn;
            HireDate = hireDate;
        }

        // behaviors
        public override string ToString()
        {
            // Output Format:
            // Ben Hill, SSN: 555-55-5555, Hire Date: XX/XX/XXXX
            return $"{firstName} {lastName}, SSN: {ssn}, Hire Date: {hireDate.ToShortDateString()}";
        }

        Double CalculatePay()
        {
            return 0;
        }

        // properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 0)
                {
                    firstName = value;
                }
                else
                {
                    firstName = "unknown";
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 0)
                {
                    lastName = value;
                }
                else
                {
                    lastName = "unknown";
                }
            }
        }

        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                // Validate input ######### or ###-##-####
                if (value.Length == 9 || value.Length == 11)
                {
                    ssn = value;
                }
                else
                {
                    ssn = "unknown";
                }
            }
        }

        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                // Validate
                if (value.Year >= 1950 && value.Year <= DateTime.Now.Year + 1)
                {
                    hireDate = value;
                }
                else
                {
                    hireDate = DateTime.MinValue;   // 01/01/0001 (blocks data if unrealistic date is given)
                }
            }
        }

        public Benefits BenefitsPackage
        {
            get
            {
                return benefits;
            }
            set
            {
                this.benefits = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hill_CourseProject_Part2
{
    internal class Benefits
    {
        // attributes
        private string healthInsurance;
        private double lifeInsurance;
        private int vacation;

        // constructors
        public Benefits()
        {
            healthInsurance = "unknown";
            lifeInsurance = 0.0;
            vacation = 0;
        }

        public Benefits(string healthInsurance, double lifeInsurance, int vacation)
        {
            this.HealthInsurance = healthInsurance;
            this.LifeInsurance = lifeInsurance;
            Vacation = vacation;
        }

        // behaviors
        public override string ToString()
        {
            return $"Health Insurance: {healthInsurance}, Life Insurance: {lifeInsurance}, " +
                $"Vacation Days: {vacation}";
        }

        // properties (get/set methods)
        public string HealthInsurance
        {
            get
            {
                return healthInsurance;
            }
            set
            {
                if (value.Length > 0)
                    healthInsurance = value;
                else
                    healthInsurance = "unknown";
            }
        }

        public double LifeInsurance
        {
            get
            {
                return lifeInsurance;
            }
            set
            {
                if (value > 0.0 && value <= 10000000.0)
                    lifeInsurance = value;
                else
                    lifeInsurance = 0.0;
            }
        }

        public int Vacation
        {
            get
            {
                return vacation;
            }
            set
            {
                if (value > 0 && value <= 40)
                    vacation = value;
                else
                    vacation = 0;
            }
        }
    }
}

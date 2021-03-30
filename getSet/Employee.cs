using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet
{
    class Employee
    {
        private int experience;
        private double salary;
        public int getexp()
        {
            return experience;
        }
        public void setexp(int value)
        {
            experience = value;
        }
        public double hisSalary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}

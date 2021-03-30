using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationAndAbstraction
{
    //this is encapsulation.it's combine all private and public class member in a single unit.
    class Student
    {
        //data hiding
        private int StudentID;
        private string StudentName;
        //Abstraction , it's provides history details.
        public int ID
        {
            get
            {
                return StudentID;
            }
            set
            {
                StudentID = value;
            }
        }
        /*this is the property of StudentName*/
        public string name
        {
            get
            {
                return StudentName;
            }
            set
            {
                StudentName = value;
            }
        }
    }
}

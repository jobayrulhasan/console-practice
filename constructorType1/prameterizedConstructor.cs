using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorType1
{
    class prameterizedConstructor
    {
        public int studentID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public prameterizedConstructor(int stID,string name,string Add)
        {
            this.studentID = stID;
            this.StudentName = name;
            this.Address = Add;
        }
    }
}

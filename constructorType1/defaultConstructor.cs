using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorType1
{
    class defaultConstructor
    {
        public int studentID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public defaultConstructor()
        {
            Address = "Dhaka";
        }
    }
}

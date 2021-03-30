using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectCreate
{

    /*this is the class*/
    class Teacher
    {
        /*fields*/
        public string TeacherName { get; set; }
        public int TeacharId { get; set; }
        public string TeacherAddress { get; set; }
        public int TeacherPhoneNumber { get; set; }

        /*method*/
        public void ShowDetails()
        {
            Console.WriteLine("Teacher details information");
            Console.WriteLine("Teacher's name: {0}\nTeacher's ID: {1}\nTeacher's Address: {2}\nTeacher's phone number: {3}",TeacherName,TeacharId,TeacherAddress,TeacherPhoneNumber);
        }
      
    }
}
    

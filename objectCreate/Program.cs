using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*object*/
            Teacher teDetails = new Teacher();
            teDetails.TeacherName = "Sharif Uddin";
            teDetails.TeacharId = 2354;
            teDetails.TeacherAddress = "4/29,Mohammadpur,Dhaka - 1207";
            teDetails.TeacherPhoneNumber = 01750908753;
            teDetails.ShowDetails();
            Teacher dtl = new Teacher();
            dtl.TeacherName = "Hamidur Rahman";
            dtl.TeacharId = 2355;
            dtl.TeacherAddress = "4/29,Mohahali,Dhaka - 1212";
            dtl.TeacherPhoneNumber = 01750908753;
            dtl.ShowDetails();
            Console.ReadKey();
        }
    }
}

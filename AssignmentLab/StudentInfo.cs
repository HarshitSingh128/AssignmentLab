using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLab
{
    public class StudentInfo
    {
        static void Main(string[] args)
        {
            Student stud = new Student();

            stud.Roll_No = 1;
            stud.Name = "Neha";
            stud.Percentage = 78;

            Console.WriteLine($"Stud RollNo:{stud.Roll_No},Stud Name:{stud.Name}:,Stud Percentage:{stud.Percentage}");
        }
    }
}

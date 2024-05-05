using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLab
{
    //7.	Create Student class with roll no, name, accept 3 subjects marks from constructor.
    //Calculate the total marks & percentage. Display student details using ToString()
    public class Student1Info
    {
        static void Main(string[] args)
        {

            Student1 student = new Student1(101, "Suraj", 70, 75, 90);


            Console.WriteLine(student.ToString());
        }
    }
}

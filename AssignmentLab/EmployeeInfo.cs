using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentLab
{



    public class EmployeeInfo
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101,"Pradnya",45000);
            Console.WriteLine(e1);
            Console.WriteLine("------By static id field --------");
            Employee e2 = new Employee( "Suraj", 78000);
            Console.WriteLine(e2);
            Employee e3 = new Employee("Manoj", 86000);
            Console.WriteLine(e3);
            Employee.DisplayTotalcount();



        }
    }
}


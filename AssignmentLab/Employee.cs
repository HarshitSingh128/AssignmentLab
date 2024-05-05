using AssignmentLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentLab
{
    //1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF.
    //Accept the value of id, name & basic salary from constructor. Calculate the employee gross salary
    //& display employee details using ToString() method
    //a.	HRA- 40% of basic salary
    ///b.TA – 20% of basic salary
    //c.	PF -12 % of basic salary
    //5.	Use above Employee class, create a static field to auto increment the employee id &
    //create static method to display the total object count.
    //6.	Use above Employee class, make a constant field as PT(professional tax) as 200.
    //Deduct the PT from salary & display the gross salary.

    public class Employee
    {
        private static int eid=1;
        private const double Pt = 200;
        private int id;
        private string name;
        private double basicsalary;
        private double hra = .4;
        private double ta = 0.2;
        private double pf = 1.2;
        // private 
        public Employee(string name, double basicsalary)

        {
            id = eid++;
            this.name = name;
            this.basicsalary = basicsalary;
            
        }
        public Employee(int id,string name,double basicsalary)
        {
            this.id = id;
            this.name = name;
            this.basicsalary = basicsalary;
        }

        public double calGross()
        {
            double gs = basicsalary+((hra * basicsalary) + (ta * basicsalary)) - (pf * basicsalary);
            return gs-Pt;
        }
        public static void DisplayTotalcount()
        {
            Console.WriteLine($"Total employee Count:{eid-1}");
        }
        public override string ToString()
        {
            return $"Id={id},Ename={name},Empsalary={basicsalary},Gosssalary={calGross()}";
        }


    }

    }



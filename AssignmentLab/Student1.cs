using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLab
{
    
    public class Student1
    {
        private int rollNo;
        private string name;
        private int[] marks = new int[3];


        public Student1(int rollNo, string name, int m1, int m2, int m3)
        {
            this.rollNo = rollNo;
            this.name = name;
            marks[0] = m1;
            marks[1] = m2;
            marks[2] = m3;
        }


        public double CalculateTotalMarks()
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return total;
        }

        public double CalculatePercentage()
        {
            double totalMarks = CalculateTotalMarks();
            return (totalMarks / (marks.Length * 100)) * 100;
        }

        public override string ToString()
        {
            return $"Roll No: {rollNo}\nName: {name}\nTotal Marks: {CalculateTotalMarks()}\nPercentage: {CalculatePercentage()}%";
        }

    }
}

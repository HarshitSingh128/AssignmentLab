using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLab
{
    //1.	WAP to print even numbers from 121 to 229 using do-while loop. 
    public class Dowhiledemo
    {

        public static void PrintEvenNub()
        {
            int i = 121;

            do
            {
               
                if (i% 2 == 0)
                {
                    Console.WriteLine("Even:"+i);
                }
                else
                {
                    Console.WriteLine("Odd:"+i);
                }
                i++;


            } while (i <= 229);

        }
        //2.	 WAP to show the use of break statement ( in for loop)
        public static void Usebreak()
        {
            int count = 0;
            for (int i = 0; i <= 10; i++)
            {
               
                count++;
                //break;
            }
            Console.WriteLine(count);
        }
        //3.	Write a program to print all alphabets from a to z. - using  for loop
       public static void PrintAlphabet()
        {
            char i;
            for (i = 'A'; i <= 'Z'; i++)
            {
                Console.WriteLine(i);
            }

        } 
        //4.	 Write a  program to find sum of all even numbers between 1 to n. 
        
        public static void SumEven(int num)
        {
            int sum = 0;
            for(int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
        //5.	 Write a program to find sum of all odd numbers between 1 to n.
        public static void SumOdd(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                if (i % 2!= 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
        //6.	 Write a  program to count number of digits in any number
        public static void Countdigit(int num)
        {
            int count = 0;
            int rem;
            while(num != 0)
            {
                rem = num % 10;
                num = num / 10;
                count++;
              

            }
            Console.WriteLine(count);
        } 
      //  7.	 Write a  program to calculate product of digits of any number.
        public static void ProductofDigit(int num)
        {
            int rem;
            int product=1;
            while (num > 0){
                rem = num % 10;
                num = num / 10;
                product = product * rem;
            }
            Console.WriteLine(product);
        }
        //8.	Write a program to find frequency of each digit in a given integer.
       // public static void Findfrequency()



        static void Main(string[] args)
        {
            //PrintEvenNub();
            //Usebreak();
            // PrintAlphabet();
            // SumEven(10);
            // SumOdd(10);
            //Countdigit(126);
            ProductofDigit(124);
        }
    }
}

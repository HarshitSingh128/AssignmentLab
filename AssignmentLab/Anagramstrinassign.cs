using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Anagramstrinassign
    {
        public static bool CheckAnagram(string s1,string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            else
            {
                s1 = s1.ToLower();
                s2 = s2.ToLower();
                char[] c1 = s1.ToCharArray();
                char[] c2 = s2.ToCharArray();
                Array.Sort(c1);
                Array.Sort(c2);
                if (Array.Equals(c1, c2))
                    return true;
                else
                    return false;
            }
        }
        static void Main(string[] args)
        {
            string s1 = "Ear";
            string s2 = "Are";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            if (CheckAnagram(s1, s2))
            {
                Console.WriteLine("Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Strings are not Anagram");
            }


        }
    }
}

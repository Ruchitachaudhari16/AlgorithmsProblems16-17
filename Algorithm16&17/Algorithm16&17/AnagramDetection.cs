using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm16_17
{
    internal class AnagramDetection
    {
        //Check weather the two strings are Anagram or Not
        public static void CheckAnagram()
        {
            string s1,s2;
            Console.WriteLine("Enter the First String");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            s2 = Console.ReadLine();

            //ToLower- Converting both the string to lower case 
            //ToCharArray-Converting both the arrays to character array.
            char[]a1=s1.ToLower().ToCharArray();
            char[]a2=s2.ToLower().ToCharArray();
            //Sort the arrays 
            Array.Sort(a1);
            Array.Sort(a2);
            string r1=new string(a1);
            string r2=new string(a2);

            if (r1 == r2)
            {
                Console.WriteLine("two strings are anagrams");
            }
            else 
            {
                Console.WriteLine("Two strings are not anagrams");
            }
        }
    }
}

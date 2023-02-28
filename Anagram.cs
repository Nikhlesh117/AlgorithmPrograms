using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Anagram
    {
        public void anagram()
        {
            Console.Write("Enter first string : ");
            string firstString = Console.ReadLine();
            Console.Write("Enter second string : ");
            string secondString = Console.ReadLine();

            if (firstString.Length != secondString.Length)
            {
                Console.WriteLine("The two strings are not anagram of each other");
            }

            char[] firstStringArr = firstString.ToCharArray();
            char[] secondStringArr = secondString.ToCharArray();

            Array.Sort(firstStringArr);
            Array.Sort(secondStringArr);

            if (String.Join("", firstStringArr) == String.Join("", secondStringArr))
            {
                Console.WriteLine("The two strings \"" + firstString + "\" and \"" + secondString + "\" are anagrams of each other");
            }
        }
    }
}



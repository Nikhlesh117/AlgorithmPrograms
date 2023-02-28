using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class PermutationsOfString
    {
        public static String Swap(String Strings, int leftIndex, int rightIndex)
        {
            char[] tempString = Strings.ToCharArray();

            char temp = tempString[leftIndex];
            tempString[leftIndex] = tempString[rightIndex];
            tempString[rightIndex] = temp;

            string SReturn = new string(tempString);
            return SReturn;
        }
        public static void Permute(String Strings, int leftIndex, int rightIndex)
        {
            if (leftIndex == rightIndex)
            {
                Console.WriteLine(Strings);
            }
            
            else
            {
                for (int i = leftIndex; i <= rightIndex; i++)
                {
                    Strings = Swap(Strings, leftIndex, i);
                    Permute(Strings, leftIndex + 1, rightIndex);
                    Strings = Swap(Strings, leftIndex, i);
                }
            }
        }
        public void Display()
        {
            Console.Write("Enter the string to find all of it's permutations : ");
            string Strings = Console.ReadLine();
            Console.WriteLine("Permutations of the string " + Strings + " are :");
            Permute(Strings, 0, Strings.Length - 1);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BinarySearch
    {
        static int BinaryS(String[] wordArray, int leftIndex, int rightIndex, String findIndexOfWord)
        {
            while (leftIndex <= rightIndex)
            {
                int middelIndex = leftIndex + (rightIndex - leftIndex) / 2;

                int Result = findIndexOfWord.CompareTo(wordArray[middelIndex]);

                if (Result == 0)
                {
                    return middelIndex;
                }
                if (Result > 0)
                {
                    leftIndex = middelIndex + 1;
                }
                else
                {
                    rightIndex = middelIndex - 1;
                }
            }
            return -1;
        }
        public void Display()
        {

            String[] wordArray = { "A", "B", "C", "D", "E", "F", "G", "H" };

            Console.Write("Words present in the list are : ");

            foreach (String word in wordArray)
            {
                Console.Write(" " + word);
            }
            Console.Write("\nEnter the word you want to find : ");
            String findIndexOfWord = Console.ReadLine();


            int foundAtPosition = BinaryS(wordArray, 0, wordArray.Length - 1, findIndexOfWord);


            if (foundAtPosition == -1)
            {
                Console.WriteLine("Word is not present in the array");
            }

            else
            {
                Console.WriteLine("The word " + findIndexOfWord + " is found at position " + foundAtPosition + " in the list");
            }
        }
    }
}

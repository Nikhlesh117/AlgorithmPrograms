using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class InsertionSort
    {
        public void Insertion()
        {
            InsertionSort insertionSort = new InsertionSort();

            Console.Write("Enter integer values one by one separated by space : ");
            string[] strings = Console.ReadLine().Split();

            int[] arr = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                arr[i] = Convert.ToInt32(strings[i]);
            }
            Console.Write("Array before sorting is : ");
            insertionSort.Display(arr);

            for (int i = 1; i < arr.Length; i++)
            {

                int val = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > val)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = val;
            }
            Console.Write("Sorted Array using Insertion sort is : ");
            insertionSort.Display(arr);
        }
        public void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
        }
    }
}

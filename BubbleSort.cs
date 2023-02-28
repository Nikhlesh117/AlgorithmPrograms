using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BubbleSort
    {
        
        public void Bubble()
        {
            BubbleSort bubbleSort = new BubbleSort();

            Console.Write("Enter integer values one by one separated by spaces : ");
            string[] strings = Console.ReadLine().Split();

            int[] arr = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                arr[i] = Convert.ToInt32(strings[i]);
            }
            Console.Write("Array before sorting is : ");
            bubbleSort.Display(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {                
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("Sorted Array using Bubble sort is : ");
            bubbleSort.Display(arr);
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

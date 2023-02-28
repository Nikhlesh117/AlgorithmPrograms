using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MergeSort
    {
        public void Merge(int[] arr, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftSubArraySize = middleIndex - leftIndex + 1;
            int rightSubArraySize = rightIndex - middleIndex;
            int[] leftSubArray = new int[leftSubArraySize];
            int[] rightSubArray = new int[rightSubArraySize];

            for (int i1 = 0; i1 < leftSubArraySize; i1++)
            {
                leftSubArray[i1] = arr[leftIndex + i1];
            }
            for (int j1 = 0; j1 < rightSubArraySize; j1++)
            {
                rightSubArray[j1] = arr[middleIndex + 1 + j1];
            }

            int i = 0, j = 0;
            int k = leftIndex;

            while (i < leftSubArraySize && j < rightSubArraySize)
            {
                if (leftSubArray[i] <= rightSubArray[j])
                {
                    arr[k] = leftSubArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightSubArray[j];
                    j++;
                }
                k++;
            }
            while (i < leftSubArraySize)
            {
                arr[k] = leftSubArray[i];
                i++;
                k++;
            }
            while (j < rightSubArraySize)
            {
                arr[k] = rightSubArray[j];
                j++;
                k++;
            }
        }
        public void Sort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                Sort(arr, leftIndex, middleIndex);
                Sort(arr, middleIndex + 1, rightIndex);
                Merge(arr, leftIndex, middleIndex, rightIndex);
            }
        }
        public void PrintArray(int[] sortArray)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(" " + sortArray[i]);
            }
            Console.WriteLine();
        }
        public void Display()
        {
            MergeSort mergeSort = new MergeSort();
            Console.Write("Enter integer values one by one separated by spaces : ");
            string[] strings = Console.ReadLine().Split();

            int[] sortArray = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                sortArray[i] = Convert.ToInt32(strings[i]);
            }

            Console.Write("Array before sorting is : ");
            mergeSort.PrintArray(sortArray);
            mergeSort.Sort(sortArray, 0, sortArray.Length - 1);

            Console.Write("Array using Merge sort is : ");
            mergeSort.PrintArray(sortArray);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    /// <summary>
    /// Represents Selection Sort Algorithm
    /// </summary>
    public class SelectionSort
    {
        public void Sort(int[] arr)
        {
            //Goes through every index in array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;

                //Goes through every number on right side of i
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //Swaps smallest number with i
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }
}
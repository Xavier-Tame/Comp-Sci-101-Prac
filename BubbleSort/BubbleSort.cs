using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Bubble Sort to sort array with int types
    /// </summary>
    public class BubbleSorter
    {
        public int[] Sort(int[] arr)
        {
            //Loop through array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //Loop to check every number on the right
                for (int x = 0; x < arr.Length - 1; x++)
                {
                    //Check if current number is larger than number on the right
                    if (arr[x] > arr[x + 1])
                    {
                        //Swap the numbers around
                        (arr[x], arr[x + 1]) = (arr[x + 1], arr[x]);
                    }
                }

            }

            return arr;
        }
    }
}
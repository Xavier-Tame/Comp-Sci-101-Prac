using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    /// <summary>
    /// Represents Insertion Sort Algorithm
    /// </summary>
    public class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            //Goes through every value in array
            for (int i = 1; i < arr.Length; i++)
            {
                //Checks if smaller than values on left and swaps
                for (int x = i; x > 0; x--)
                {
                    if (arr[x] < arr[x - 1])
                    {
                        (arr[x], arr[x - 1]) = (arr[x - 1], arr[x]);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            return arr;

        }
    }
}
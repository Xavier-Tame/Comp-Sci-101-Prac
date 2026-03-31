using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selection_Sort
{
    public class SelectionSort
    {
        public int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int x = i; x < arr.Length; x++)
                {
                    if (arr[i] > arr[x])
                    {
                        (arr[i], arr[x]) = (arr[x], arr[i]);
                    }
                }
            }

            return arr;
        }
    }
}
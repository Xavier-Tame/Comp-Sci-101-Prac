using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularArray
{
    /// <summary>
    /// Circular array with basic functions
    /// </summary>
    public class CircularArray<T>
    {
        T[] arr;
        int head;
        int tail;

        public CircularArray(int size)
        {
            arr = new T[size];
            head = 0;
            tail = 0;
        }

        //Inserts element to end of Array
        public void Insert(T value)
        {
            arr[tail] = value;
            tail = (tail + 1) % arr.Length;
        }

        //Removes element at front of array
        public T Remove()
        {
            T type = arr[head];
            arr[head] = default(T);
            head = (head + 1) % arr.Length;

            return type;
        }

        //Print all elements of array from head
        public void PrintArr()
        {

            int current = head;
            int count = 0;

            while (count < arr.Length - 1)
            {
                System.Console.WriteLine(arr[current]);

                current = (current + 1) % arr.Length;
                count++;
            }
        }
    }
}
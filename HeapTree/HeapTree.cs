using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeapTree
{
    /// <summary>
    /// Max Heap Tree with basic functions
    /// </summary>
    public class MaxHeap
    {
        int[] heapArr;
        int heapSize;

        public MaxHeap(int size)
        {
            heapArr = new int[size];
        }

        void Swap(int i, int j)
        {
            //Swaps the array values of i and j
            (heapArr[i], heapArr[j]) = (heapArr[j], heapArr[i]);
        }


        int Parent(int index)
        {
            //Returns the Parent index
            return (index - 1) / 2;
        }

        int LeftChild(int index)
        {
            //Returns the LeftChild index
            return (2 * index) + 1;
        }

        int RightChild(int index)
        {
            //Returns the RightChild index
            return (2 * index) + 2;
        }

        //Adds value to HeapTree
        public void Add(int num)
        {
            heapArr[heapSize] = num;
            int index = heapSize;
            heapSize++;

            int value = heapArr[index];
            int parent = heapArr[Parent(index)];

            while (index > 0 && value > parent)
            {
                Swap(index, Parent(index));

                index = Parent(index);

                value = heapArr[index];
                parent = heapArr[Parent(index)];
            }
        }

        //Fixes Max Heap Tree structure
        public void Heapify(int index)
        {
            int largest = index;
            int leftIndex = LeftChild(index);
            int rightIndex = RightChild(index);

            //Compares left number with largest number
            if (leftIndex < heapSize && heapArr[leftIndex] > heapArr[largest])
            {
                largest = leftIndex;
            }
            //Compares right number with largest number
            if (rightIndex < heapSize && heapArr[rightIndex] > heapArr[largest])
            {
                largest = rightIndex;
            }

            if (largest != index)
            {
                Swap(largest, index);

                Heapify(largest);
            }

        }

        //Removes root of tree (The top node)
        public void RemoveRoot()
        {
            if (heapSize == 0)
            {
                return;
            }

            int root = heapArr[0];

            //Replaces root with last node
            heapArr[0] = heapArr[heapSize - 1];
            heapArr[heapSize - 1] = default;

            heapSize--;

            //Fix Max Heap Tree structure
            Heapify(0);

        }

        //Prints the tree in order of the array
        public void PrintTree()
        {
            foreach (int num in heapArr)
            {
                System.Console.WriteLine(num);
            }
        }








    }
}
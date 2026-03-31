using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SLinkedList<int> intList = new SLinkedList<int>();

            intList.InsertFront(5);
            intList.DeleteFront();
            intList.InsertFront(10);
            intList.InsertFront(15);
            intList.InsertFront(2);
            intList.InsertFront(8);
            intList.InsertFront(10);

            intList.InsertEnd(34);

            intList.PrintList();

            System.Console.WriteLine();

            intList.DeleteEnd();

            intList.PrintList();
        }
    }

}

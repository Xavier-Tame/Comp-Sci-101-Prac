using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Node<T>
    {
        public Node<T>? next;
        public Node<T>? previous;
        public T data { get; }

        public Node(T data)
        {
            this.data = data;
        }
    }

    /// <summary>
    /// Doubly Linked List with basic functions
    /// </summary>
    public class DLinkedList<T>
    {
        Node<T>? head = null;
        Node<T>? tail = null;

        //Inserts at front of list
        public void InsertFront(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;

                return;
            }

            //Changes pointers to maintain the doubly linked list's structure
            head.previous = newNode;
            newNode.next = head;

            head = newNode;



        }

        //Inserts at back of list
        public void InsertBack(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                InsertFront(data);

                return;
            }

            //Changes pointers to maintain the doubly linked list's structure
            newNode.previous = tail;
            tail.next = newNode;

            tail = newNode;

        }

        //Deletes at front of list
        public void DeleteFront()
        {
            if (head.next != null)
            {
                head.next.previous = null;
                head = head.next;

                return;
            }

            //Clears pointers if nothing in next node
            head = null;
            tail = null;
        }

        //Deletes at back of list
        public void DeleteBack()
        {
            if (tail.previous != null)
            {
                tail.previous.next = null;
                tail = tail.previous;

                return;
            }

            //Clears pointers if nothing in previous node
            tail = null;
            head = null;
        }

        //Prints list from front pointer to back pointer
        public void PrintListForward()
        {
            Node<T>? currentPlace = head;

            while (currentPlace != null)
            {
                System.Console.WriteLine(currentPlace.data);
                currentPlace = currentPlace.next;
            }
        }

        //Prints list from back pointer to front pointer
        public void PrintListBackward()
        {
            Node<T>? currentPlace = tail;

            while (currentPlace != null)
            {
                System.Console.WriteLine(currentPlace.data);
                currentPlace = currentPlace.previous;
            }
        }
    }
}
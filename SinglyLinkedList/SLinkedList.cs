using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Node<T>
    {
        public Node<T>? next;
        public T data;

        public Node(T data)
        {
            this.data = data;
        }
    }

    /// <summary>
    /// Represents a basic Singly Linked List with head pointer
    /// </summary>
    public class SLinkedList<T>
    {
        Node<T>? head = null;

        public void InsertFront(T data)
        {
            Node<T> newNode = new Node<T>(data);

            newNode.next = head;
            head = newNode;
        }

        public void InsertEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);

            Node<T>? currentPlace = head;

            try
            {
                while (currentPlace.next != null)
                {
                    currentPlace = currentPlace.next;
                }

                currentPlace.next = newNode;
            }
            catch (System.NullReferenceException)
            {
                InsertFront(data);
            }

        }

        public void DeleteFront()
        {
            head = head.next;
        }

        public void DeleteEnd()
        {
            Node<T>? previousPlace;
            Node<T>? currentPlace = head;

            try
            {
                //Search 1 node ahead to prevent rerun through list
                while (currentPlace.next.next != null)
                {
                    currentPlace = currentPlace.next;
                }

                currentPlace.next = null;
            }
            catch (System.NullReferenceException)
            {
                DeleteFront();
            }

        }

        public void PrintList()
        {
            Node<T>? currentPlace = head;

            while (currentPlace != null)
            {
                System.Console.WriteLine(currentPlace.data);

                currentPlace = currentPlace.next;
            }
        }


    }

}
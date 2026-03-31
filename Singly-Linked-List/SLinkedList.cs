using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    public class SLinkedList<T>
    {
        Node<T>? head = null;

        public void AddBeginning(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = this.head;
            this.head = newNode;

        }

        public void AddEnd(T data)
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
                AddBeginning(data);
            }



        }

        public void DeleteFront()
        {
            head = head.next;
        }

        public void DeleteBack()
        {
            Node<T>? previousPlace;
            Node<T>? currentPlace = head;

            try
            {
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



    class Node<T>
    {
        public Node<T>? next;
        public T data;
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }

}
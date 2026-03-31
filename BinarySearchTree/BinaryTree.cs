using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// Left Node is &lt;= value and right Node &gt; value
    /// </summary>
    class Node
    {
        public int value;
        public Node? leftNode;
        public Node? rightNode;

        public Node(int value)
        {
            this.value = value;
        }

    }

    /// <summary>
    /// Basic non self balancing Binary Tree with Search algorithm
    /// </summary>
    public class BinaryTree
    {
        Node? startNode;

        public void Add(int num)
        {
            Node? newNode = new Node(num);

            if (startNode == null)
            {
                startNode = newNode;
                System.Console.WriteLine("Number added");
                return;
            }

            Node currentNode = startNode;

            while (currentNode.value != newNode.value)
            {
                if (num <= currentNode.value)
                {
                    if (currentNode.leftNode == null)
                    {
                        currentNode.leftNode = newNode;
                        currentNode = currentNode.leftNode;
                    }
                }
                else if (num > currentNode.value)
                {
                    if (currentNode.rightNode == null)
                    {
                        currentNode.rightNode = newNode;
                        currentNode = currentNode.rightNode;
                    }
                }
            }
            System.Console.WriteLine("Number added");

        }

        /// <summary>
        /// Searches for a particular number in the Tree and returns True if found
        /// </summary>
        public bool Search(int num)
        {
            Node currentNode = startNode;

            while (currentNode.value != num)
            {
                System.Console.WriteLine(currentNode.value);

                if (num < currentNode.value)
                {
                    currentNode = currentNode.leftNode;
                }
                else if (num > currentNode.value)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    return false;
                }

            }

            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Undirected_Graph
{
    class Node<T>
    {
        public List<Node<T>> nodeRelationships;
        public T data { get; }
        public Node(T? data)
        {
            this.data = data;
            this.nodeRelationships = new List<Node<T>>();
        }

        /// <summary>
        /// Adds param relationship to current node
        /// </summary>
        /// <param name="relationshipNode"></param>
        public void AddRelationship(Node<T> relationshipNode)
        {
            //Add relationshipNode to nodeRelationships list
            nodeRelationships.Add(relationshipNode);
        }
    }


    /// <summary>
    /// Represents Undirected Graph with adding relationships to existing users
    /// </summary>
    public class UndirectedGraph<T>
    {
        //List to hold all nodes
        List<Node<T>> nodes = new List<Node<T>>();

        public void AddNew(T data)
        {
            Node<T> newNode = new Node<T>(data);
            nodes.Add(newNode);
        }

        //Do full BFS from particular node
        Node<T>? BFSFromNode(Node<T> startNode, HashSet<Node<T>> visited, T dataToFind)
        {
            //Create queue as needed for BFS
            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();
                visited.Add(current);

                System.Console.WriteLine(current.data);

                if (current.data.Equals(dataToFind))
                {
                    return current;
                }

                foreach (Node<T> relationship in current.nodeRelationships)
                {

                    if (!visited.Contains(relationship))
                    {
                        queue.Enqueue(relationship);
                        continue;
                    }
                }

            }
            return null;
        }

        //Search graph using Breadth First Search (BFS)
        Node<T>? SearchGraph(T data)
        {
            //Hashset that holds all visited nodes
            HashSet<Node<T>> visited = new HashSet<Node<T>>();

            foreach (Node<T> node in nodes)
            {
                if (visited.Contains(node))
                {
                    continue;
                }
                else if (!visited.Contains(node) && !node.data.Equals(data))
                {
                    //If node isnt visited start BFS at node to avoid stray nodes
                    Node<T>? valueSearch = BFSFromNode(node, visited, data);

                    if (valueSearch != null)
                        return valueSearch;

                    continue;
                }

                return node;
            }
            return null;
        }

        //Used to add a relationship with 2 existing nodes
        public void AddExistRelationship(T currentData, T relationshipData)
        {

            //Check to make sure they aren't equal
            if (!currentData.Equals(relationshipData))
            {

                //Search for nodes using BFS to check if they exist
                Node<T>? currentDataNode = SearchGraph(currentData);
                Node<T>? relationshipDataNode = SearchGraph(relationshipData);

                //Another check to make sure Nodes aren't null
                if (currentDataNode != null && relationshipDataNode != null)
                {
                    System.Console.WriteLine("Current data node found: " + currentDataNode.data);
                    System.Console.WriteLine("Current relationship data node found: " + relationshipDataNode.data);

                    currentDataNode.AddRelationship(relationshipDataNode);
                    relationshipDataNode.AddRelationship(currentDataNode);
                }
            }
        }

        public void PrintNodeValues()
        {
            System.Console.WriteLine();
            foreach (Node<T> node in nodes)
            {
                System.Console.WriteLine(node.data);
            }
        }
    }
}
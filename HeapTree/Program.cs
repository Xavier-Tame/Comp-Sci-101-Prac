namespace HeapTree
{
    class Program
    {

        public static void Main(string[] args)
        {
            MaxHeap tree = new MaxHeap(9);
            tree.Add(15);
            tree.Add(22);
            tree.Add(11);
            tree.Add(9);
            tree.Add(7);
            tree.Add(12);
            tree.Add(32);
            tree.Add(10);
            tree.Add(4);

            tree.PrintTree();

            System.Console.WriteLine();

            tree.RemoveRoot();

            tree.PrintTree();
        }
    }
}

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bst = new BinaryTree();

            bst.Add(5);
            bst.Add(10);
            bst.Add(2);
            bst.Add(9);
            bst.Add(1);
            bst.Add(6);
            bool valueExist = bst.Search(10);
            bool valueExist1 = bst.Search(6);
            System.Console.WriteLine(valueExist + " " + valueExist1);
        }
    }
}

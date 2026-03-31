namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList<int> doublyList = new DLinkedList<int>();

            doublyList.InsertBack(34);
            doublyList.InsertFront(5);
            doublyList.InsertFront(10);
            doublyList.InsertFront(15);
            doublyList.DeleteBack();
            doublyList.InsertFront(2);
            doublyList.InsertFront(8);
            doublyList.DeleteFront();
            doublyList.InsertBack(5);

            doublyList.PrintListForward();

            System.Console.WriteLine();

            doublyList.PrintListBackward();
        }

    }
}





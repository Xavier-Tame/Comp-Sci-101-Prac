namespace Singly_Linked_List
{
    class Program
    {


        static void Main(string[] args)
        {
            SLinkedList<int> intList = new SLinkedList<int>();

            intList.AddBeginning(5);
            intList.DeleteFront();
            intList.AddBeginning(10);
            intList.AddBeginning(15);
            intList.AddBeginning(2);
            intList.AddBeginning(8);
            intList.AddBeginning(10);

            intList.AddEnd(34);

            intList.PrintList();

            System.Console.WriteLine(" ");

            intList.DeleteBack();

            intList.PrintList();
        }
    }

}

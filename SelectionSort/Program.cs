namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 15, 22, 8, 3, 9, 12 };

            SelectionSort sortNum = new SelectionSort();
            sortNum.Sort(numArray);

            foreach (int i in numArray)
            {
                System.Console.WriteLine(i);
            }
        }
    }

}

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 15, 22, 8, 3, 9, 12 };

            SelectionSort sortNum = new SelectionSort();
            int[] sortedArr = sortNum.Sort(numArray);

            foreach (int i in sortedArr)
            {
                System.Console.WriteLine(i);
            }
        }
    }

}

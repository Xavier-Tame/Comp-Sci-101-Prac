namespace MergeSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10, 15 };

            MergeSort sortArr = new MergeSort();
            int[] sortedNums = sortArr.Sort(arr);

            foreach (int i in sortedNums)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}



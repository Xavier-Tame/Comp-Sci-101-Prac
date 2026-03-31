namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 10, 4, 7, 6, 9 };

            QuickSort sortNums = new QuickSort();
            int[] sortedNums = sortNums.Sort(nums, 0, nums.Length - 1);

            foreach (int i in sortedNums)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}

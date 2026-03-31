namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            InsertionSort sortNum = new InsertionSort();
            int[] nums = { 2, 1, 8, 12, 15, 22, 5, 43 };
            int[] sortedNum = sortNum.Sort(nums);


            foreach (int i in sortedNum)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}


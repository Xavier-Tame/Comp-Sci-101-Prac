namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 52, 8, 12, 94, 26, 8, 5, 7 };

            BubbleSorter sortNumbers = new BubbleSorter();
            int[] sortedNumbers = sortNumbers.Sort(numbers);

            foreach (int num in sortedNumbers)
            {
                System.Console.WriteLine(num);
            }
        }
    }

}

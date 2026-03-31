namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedNumbers = { 2, 5, 8, 15, 54, 55, 67 };

            BinarySearch sorted = new BinarySearch();

            bool exists = sorted.Search(sortedNumbers, 17);

            System.Console.WriteLine(exists);

        }
    }
}
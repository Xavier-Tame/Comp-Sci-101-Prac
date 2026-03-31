namespace CircularArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            CircularArray<int> array = new CircularArray<int>(5);
            array.Insert(5);
            array.Insert(2);
            array.Insert(3);
            array.Insert(4);
            array.Insert(6);

            array.PrintArr();

            array.Remove();
            array.Remove();
            array.Remove();
            array.Remove();

            array.PrintArr();
        }
    }
}

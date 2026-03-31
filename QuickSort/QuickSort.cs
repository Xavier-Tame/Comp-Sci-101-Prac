namespace QuickSort
{
    /// <summary>
    /// Represents a QuickSort Algorithm
    /// </summary>
    public class QuickSort
    {
        public int[] Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                //Finds partition index
                var partitionIndex = Partition(arr, low, high);

                //Sort left partition
                Sort(arr, low, partitionIndex - 1);
                //Sort right partition
                Sort(arr, partitionIndex + 1, high);

            }

            return arr;
        }

        int Partition(int[] arr, int low, int high)
        {
            int lowIndex = low - 1;
            int pivot = arr[high];

            //Finds the point which divides low and high (low index)
            for (int i = low; i <= high; i++)
            {
                if (arr[i] < pivot)
                {
                    lowIndex++;
                    //Swap if number smaller than pivot
                    (arr[lowIndex], arr[i]) = (arr[i], arr[lowIndex]);
                }

            }

            //Does final swap to make sure everything gets touched
            (arr[lowIndex + 1], arr[high]) = (arr[high], arr[lowIndex + 1]);

            return lowIndex + 1;
        }
    }
}
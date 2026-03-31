namespace MergeSort
{
    /// <summary>
    /// Represents Merge Sort Algorithm
    /// </summary>
    public class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            // Start sorting
            Process(arr);
            // Return sorted array
            return arr;

        }

        void Merge(int[] arr, int[] leftArr, int[] rightArr)
        {
            int leftLength = leftArr.Length;
            int rightLength = rightArr.Length;

            int i = 0, j = 0, k = 0;

            //Merge the left and right subarrays into the original array
            while (i < leftLength && j < rightLength)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            //Copy remaining elements from the left subarray (if any)
            while (i < leftLength)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            //Copy remaining elements from the right subarray (if any)
            while (j < rightLength)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }

        void Process(int[] arr)
        {
            int[] leftArr;
            int[] rightArr;

            if (arr.Length > 1)
            {
                //Establish middle of array
                int mid = (int)Math.Floor((Double)arr.Length / 2);

                //Establish array sizes
                leftArr = new int[arr.Length - mid];
                rightArr = new int[mid];

                //Copy elements to left and right subarrays
                Array.Copy(arr, 0, leftArr, 0, (arr.Length - mid));
                Array.Copy(arr, (arr.Length - mid), rightArr, 0, mid);

                //Recursively sort the left and right subarrays
                Process(leftArr);
                Process(rightArr);

                //Merge the subarrays
                Merge(arr, leftArr, rightArr);
            }


        }


    }
}
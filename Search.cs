namespace DSA
{
    static class Search
    {
        public static int LinearSearch(int[] arr, int num)
        {
            for(int i=0; i< arr.Length; i++)
            {
                if(arr[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if(mid == num)
                {
                    return mid;
                }
                else if(arr[mid] < num)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;

        }
    }
}

namespace Big_O_notation
{
    internal class TimeComplexity
    {
        public static void Main(string[] args)
        {
            /*
            the below codes are used to invoke methods to know whether these are works as expected 

            var result = BinarySearch(5, new int[] { 1, 2, 3, 4, 6, 7, 7, 9, 10, 12, 5 });
            Console.WriteLine("the result: " + result);
             */

            Console.ReadLine();
        }

        /// <summary>
        /// Before passing an array into this method please consider passing that as a sorted array. 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int BinarySearch(int num, int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == num)
                {
                    return mid; // found
                }
                else if (arr[mid] < num)
                {
                    left = mid + 1; // search right half
                }
                else
                {
                    right = mid - 1; // search left half
                }
            }
            return -1; // not found
        }
        
        /// <summary>
        /// find the maximum number from the array by using only DSA
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}


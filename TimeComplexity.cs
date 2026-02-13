namespace Big_O_notation
{
    internal class TimeComplexity
    {
        public static void Main(string[] args)
        {
            var result = BinarySearch(5, new int[] { 1, 2, 3, 4, 6, 7, 7, 9, 10, 12, 5 });
            Console.WriteLine("the result: " + result);
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
    }
}


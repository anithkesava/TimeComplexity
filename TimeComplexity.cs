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
            var arr = new int[] { 2, 1, 4, 3, 6, 5 };
            SplitIntoHalf(arr);
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

        public static void SplitIntoHalf(int[] arr)
        {
            int mid = arr.Length/2;
            var left = new int[mid];
            var right = new int[arr.Length - mid];

            for(int i=0;i<mid;i++)
            {
                left[i] = arr[i];
            }
            Console.WriteLine("left: "+string.Join(',', left));
            for(int i =mid; i<arr.Length;i++)
            {
                right[i-mid] = arr[i]; 
            }
            Console.WriteLine("right: "+string.Join(',', right));
        }
        /// <summary>
        /// the below implementation of code contains various Sort and Seach Algorithms thats needs to be done 
        /// </summary>
        /// <param name="arr"></param>
        /// <exception cref="NotImplementedException"></exception>

        #region Algorithms
        public static void BubbleSort(int[] arr)
        {
            throw new NotImplementedException("Bubble Sort Implementation haven't done Yet");
        }
        public static void MergeSort(int[] arr)
        {
            #region MERGE SORT EXPLANATION
            /*
             understanding the merge sort with an example - [2, 1, 10, 8, 7, 6]
             Its comes under the time complexity - O(n log n), 

             REMEMBER THE GOLDEN RULE : DIVIDE & CONQUER 
             
             --- DIVIDE ---,  
             step 1: 
             divide into halves: 
             [2,1,10] ,  [8, 7, 6] 
             and further division until the overall arrays gets into individual parts like this:
             [2], [1], [10], [8], [7], [6]
             
             --- CONQUER ---, 
             now we need to make a pair on this,  
             [1, 2], [8, 10], [6, 7] 

             two pointer rule, 
             left side - [1,2]
             right side - [8, 10]

             step 1: 
             compare the front element from the both, 
             1 vs 8 then the result array should be [1], then move one forward from where we pick the one (left side) 
             result [1]. 

             step 2: 
             compare 2 vs 8 then the result would be [1, 2] then move one forward from the left then nothing is there so 
             append the remaining part from the right side. 
             result [1, 2, 8, 10]
            
             step 3: 
             now we get one sorted list -> [1,2, 8, 10] 
             and we already have one sorted list -> [6, 7] 

             so same again. 
             left -> [1,2,8,10]
             right -> [6, 7] 

             starts with, compare the front element from both sides
             step 4: 
             1 vs 6, 
             result [1] , moves the left side one forward. 

             step 5: 
             2 vs 6, 
             result[1, 2], moves the left side one forward. 

             step 6: 
             8 vs 6, 
             result [1, 2, 6], moves the right side one forward. 

             step 7: 
             8 vs 7, 
             result [1, 2, 6, 7], moves the right one forward but one elements left so append the remaining left side elements
             --> final result [1, 2, 6, 7, 8, 10]
             
             */
            #endregion

            #region MERGE SORT LOGIC

            //lets starts with split the whole array or list into single piece elements, 


            #endregion
            throw new NotImplementedException("Merge Sort Implementation haven't done Yet");
        }

        public static void LinearSearch(int[] arr)
        {
            throw new NotImplementedException("Linear Search Implementation haven't done Yet");
        }
        public static void BinarySearch(int[] arr)
        {
            throw new NotImplementedException("Binary Search Implementation haven't done Yet");
        }
        #endregion
    }
}


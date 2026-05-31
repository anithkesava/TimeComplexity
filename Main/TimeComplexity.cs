using Big_O_notation.Patterns.SlidingWindow;
using Big_O_notation.Patterns.TwoPointer;

namespace Big_O_notation.Main
{
    public class TimeComplexity
    {
        public static void Main(string[] args)
        {
            /*
            the below codes are used to invoke methods to know whether these are works as expected 
            var result = BinarySearch(5, new int[] { 1, 2, 3, 4, 6, 7, 7, 9, 10, 12, 5 });
            Console.WriteLine("the result: " + result);

            var arr = new int[] { 2, 1, 4, 3, 6, 5 };
            SplitIntoHalf(arr);

            two pointer - opposite direction - HasPairWithSum: 

            var arr = new int[] { 1, 2, 3, 4, 6 };
            var result = TwoPointerProblems.HasPairWithSum(arr, 5);
            if (!result) Console.WriteLine("No Pair Makes the Target: " + 5);
            else Console.WriteLine("Result: " + result);

            two pointer - same direction - HasPairWithSum: 

            var arr = new int[] { 1, 1, 2, 2, 3, 3 };
            int k = TwoPointerProblems.RemoveDuplicates(arr);
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr[i]+" ");
            }

            var array = new int[] { 3, 2, 4 };
            int target = 6;
            var result = TwoSum(array, target);
            Console.WriteLine(string.Join(",", result));
            
            var nums = new List<int> { 3, 2, 4, 3, 2 };
            TwoPointerProblems.RemoveDuplicates(nums); 

            var nums = new int[] { 4, 2, 7, 1, 3 };
            TwoPointerProblems.QuickSort(nums, 0, nums.Length - 1);
            Console.WriteLine(string.Join(",", nums));
            
            var arr = new int[] { 2, 1, 4, 3, 5 };
            var target = 9;
            var output = TwoPointerProblems.SumofPairHashMap(arr, target);
            Console.WriteLine("the final output: [" + string.Join(",", output)+"]"); 

            var array = new int[] { 1, 1, 2, 3, 4, 4, 5, 6 };
            int k = TwoPointerProblems.ShortArrayWithUniqueValues(array);
            for(int i=0;i<k;i++)
            {
                Console.Write(array[i]+" ");
            }
            var array = new int[] { 0, 3, 0, 7, 0, 1 };
            var result = TwoPointerProblems.MoveZeros(array);

            var array = new int[] { 1, 2, 3, 4, 2, 3, 1 };
            int target = 2;
            var result = TwoPointerProblems.RemoveOccurance(array, target);

            var arr = new int[] { -2, -1, 0, 1, 2 };
            TwoPointerProblems.SortedSquare(arr);

            var arr = new int[] { 0, 1, 1, 1, 2, 2, 2, 3 };
            int k = TwoPointerProblems.RemoveDuplicatesII(arr);
            Console.WriteLine("the final array of arr[slow-1]: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int j = TwoPointerProblems.RemoveDuplicatesIINew(arr);
            Console.WriteLine("\n the final array of arr[slow-2]: ");
            for (int i = 0; i < j; i++)
            {
                Console.Write(arr[i] + " ");
            }

            var str = "Malayyyalam@#$" ;
            TwoPointerProblems.IsValidPalindrome(str) ;

            var str = "@#$";
            TwoPointerProblems.IsValidPalindromeII(str) ;
            */


            var array = new int[] { 1, 3, 4, 1, 2, 2 };
            int k = 3;
            SlidingWindowProblems.AlternativeSumSubarray(array, k);
            Console.ReadLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                    return new int[] { left, right };
                if (sum < target)
                    left++;
                else
                    right--;
            }
            return new int[] { -1, -1 };
        }

        #region Search Algorithms
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
        #endregion end of Search Algorithms
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
            int mid = arr.Length / 2;
            var left = new int[mid];
            var right = new int[arr.Length - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            Console.WriteLine("left: " + string.Join(',', left));
            for (int i = mid; i < arr.Length; i++)
            {
                right[i - mid] = arr[i];
            }
            Console.WriteLine("right: " + string.Join(',', right));
        }
        public static void RecursionSpliting(int startIndex, int EndIndex)
        {
            if (startIndex < EndIndex)
            {
                //only execute if the index numbers are different. 
            }

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



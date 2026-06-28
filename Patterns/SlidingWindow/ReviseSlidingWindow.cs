using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Big_O_notation.Patterns.SlidingWindow
{
    public class ReviseSlidingWindow
    {
        public static int SmallestSumSubarray(int[] arr, int target)
        {
            int left = 0;
            int currentWindowsize = 0;
            int MinWindowSize = int.MaxValue;
            int sum = 0;
            for (int right = 0; right < arr.Length; right++)
            {
                sum += arr[right];
                while (sum >= target)
                {
                    currentWindowsize = (right - left) + 1;
                    MinWindowSize = Math.Min(currentWindowsize, MinWindowSize);
                    sum -= arr[left];
                    left++;
                }
            }
            return MinWindowSize;
        }
        public static int MaxSumSubarray(int[] arr, int size)
        {
            int left = 0;
            int right = size - 1;
            int lastIndex = arr.Length - 1;
            int maxSubarray = int.MinValue;
            int currentWindowSum = 0;
            while (right <= lastIndex)
            {
                if (left == 0)
                {
                    for (int i = 0; i < size; i++)
                    {
                        currentWindowSum += arr[i];
                    }
                }
                else
                {
                    currentWindowSum = (currentWindowSum - arr[left - 1]) + arr[right];
                }
                right++;
                left++;
                maxSubarray = Math.Max(maxSubarray, currentWindowSum);
            }
            return maxSubarray;
        }
        public static int AverageGreaterThanOrEqualThreshold(int[] arr, int size, int threshold)
        {
            int windowSum = 0;
            int left = 0;
            int right = size - 1;
            int subarrayCount = 0;
            int average = 0;
            while (right < arr.Length) //rewriting this - no lastElementIndex is required
            {
                if (left == 0)
                {
                    for (int i = 0; i <= right; i++)
                    {
                        windowSum += arr[i];
                    }
                }
                else
                    windowSum = (windowSum - arr[left-1]) + arr[right];
                average = windowSum / size;
                if (average >= threshold)
                    subarrayCount++;
                left++;
                right++;
            }
            return subarrayCount;
        }
    }
}

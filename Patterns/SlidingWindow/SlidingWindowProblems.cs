using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Big_O_notation.Patterns.SlidingWindow
{
    public class SlidingWindowProblems
    {
        //fixed window size - problems
        public static int MaxSumSubarray(int[] array, int size)
        {
            int lastWindowElement = array.Length - 1;
            int MaxSum = 0;
            int currentWindowSum = 0;
            int left = 0;
            int right = size - 1;
            while (right <= lastWindowElement)
            {
                if (left == 0)
                {
                    for (int i = 0; i <= right; i++)
                    {
                        currentWindowSum += array[i];
                    }
                }
                else
                {
                    currentWindowSum = (currentWindowSum - array[left - 1]) + array[right];
                }
                MaxSum = Math.Max(MaxSum, currentWindowSum);
                left++;
                right++;
            }
            return MaxSum;
        }

        public static double MaximumAverageOfSubArray(int[] array, int k)
        {
            int lastWindowElement = array.Length - 1;
            double MaxAverage = double.MinValue;
            int currentWindowSum = 0;
            int left = 0;
            int right = k - 1;
            while (right <= lastWindowElement)
            {
                if (left == 0)
                {
                    for (int i = 0; i <= right; i++)
                    {
                        currentWindowSum += array[i];
                    }
                }
                else
                {
                    currentWindowSum = (currentWindowSum - array[left - 1]) + array[right];
                }
                double AverageSum = (double)currentWindowSum / k;
                MaxAverage = Math.Max(MaxAverage, AverageSum);
                left++;
                right++;
            }
            return MaxAverage;
        }

        public static int?[] FirstNegativeValueInEveryWindow(int[] arr, int k)
        {
            int left = 0;
            int right = k - 1;
            int lastWindowIndex = arr.Length - 1;
            int n = (arr.Length - k) + 1;
            int?[] array = new int?[n];
            int index = 0;

            while (right <= lastWindowIndex)
            {
                for (int i = left; i <= right; i++)
                {
                    if (arr[i] < 0)
                    {
                        array[index] = arr[i];
                        break;
                    }
                }
                index++;
                left++;
                right++;
            }
            return array;
        }

        //variable window size - problems

        public static int SumSmallestSubarrayElementsIsTheTarget(int[] array, int target)
        {
            int left = 0;
            int MinLength = int.MaxValue;
            int sum = 0;

            for (int right = 0; right < array.Length; right++)
            {
                sum += array[right];
                while (sum >= target)
                {
                    int currentlength = (right - left) + 1;
                    MinLength = Math.Min(currentlength, MinLength);

                    sum -= array[left];
                    left++;
                }
            }
            return MinLength;
        }
    }
}

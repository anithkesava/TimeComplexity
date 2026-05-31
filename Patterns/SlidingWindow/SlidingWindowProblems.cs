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
            int MaxAverage = 0;
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
                int AverageSum = currentWindowSum / k;
                MaxAverage = Math.Max(MaxAverage, AverageSum);
                left++;
                right++;
            }
            return MaxAverage;
        }
    }
}

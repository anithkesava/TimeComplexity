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
            for(int right = 0; right < arr.Length; right++)
            {
               sum += arr[right];
                while(sum >= target)
                {
                    currentWindowsize = (right - left) + 1;
                    MinWindowSize = Math.Min(currentWindowsize, MinWindowSize);
                    sum -= arr[left];
                    left++;
                }
            }
            return MinWindowSize;
        }
    }
}

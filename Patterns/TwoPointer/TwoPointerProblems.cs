using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Big_O_notation.Patterns.TwoPointer
{
    public class TwoPointerProblems
    {
        public static bool HasPairWithSum(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target) return true;
                if (sum > target) right--;
                else left++;
            }
            return false;
        }
        public static int RemoveDuplicatesTwoPointers(int[] arr)
        {
            //this will only works for a sorted array? shall we use HashMap instead ??
            int slow = 0;
            for (int fast = 1; fast < arr.Length; fast++)
            {
                if (arr[slow] != arr[fast])
                {
                    slow++;
                    arr[slow] = arr[fast];//1
                }
            }
            return slow + 1;
        }
        public static int[] SumofPairIsTarget(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target) return new int[] { arr[left], arr[right] };
                if (sum < target) left++;
                else right--;
            }
            return new int[0];
        }
        public static int ShortArrayWithUniqueValues(int[] arr)
        {
            int slow = 0;
            for (int fast = 1; fast < arr.Length; fast++)
            {
                if (arr[slow] != arr[fast])
                {
                    slow++;
                    arr[slow] = arr[fast];
                }
            }
            return slow + 1;
        }
        public static int[] ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            return arr;
        }
        public static int[] MoveZeros(int[] arr)
        {
            int slow = 0;
            for (int fast = 0; fast < arr.Length; fast++)
            {
                if (arr[fast] != 0)
                {
                    if (slow != fast)
                    {
                        int temp = arr[slow];
                        arr[slow] = arr[fast];
                        arr[fast] = temp;
                        slow++;
                    }
                }
            }
            return arr;
        }
        public static int RemoveOccurance(int[] arr, int num)
        {
            int slow = 0;
            for (int fast = 0; fast < arr.Length; fast++)
            {
                if (arr[fast] != num)
                {
                    int temp = arr[slow];
                    arr[slow] = arr[fast];
                    arr[fast] = temp;
                    slow++;
                }
            }
            return slow;
        }
        public static int[] SortedSquare(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            int left = 0;
            int right = arr.Length - 1, index = arr.Length - 1;
            int[] result = new int[arr.Length];
            while (left <= right)
            {
                if (arr[left] > arr[right])
                {
                    result[index] = arr[left];
                    left++;
                }
                else
                {
                    result[index] = arr[right];
                    right--;
                }
                index--;
            }
            return result;
        }
        public static int RemoveDuplicatesII(int[] arr)
        {
            int slow = 2;
            for (int fast = 2; fast < arr.Length; fast++)
            {
                if (arr[slow - 2] != arr[fast])
                {
                    arr[slow] = arr[fast];
                    slow++;
                }
            }
            return slow + 1;
        }
    }
}

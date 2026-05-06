using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_O_notation.Patterns.Sorting
{
    internal class QuickSortProblem
    {
        public static void QuickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(nums, low, high);
                QuickSort(nums, low, pivotIndex - 1);
                QuickSort(nums, pivotIndex + 1, high);
            }
        }
        public static int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    Swap(nums, i, j);
                }
            }
            Swap(nums, i + 1, high);
            return i + 1;
        }
        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

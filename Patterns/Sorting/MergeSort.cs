using System;

public class MergeSortExample
{
    public static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point
            int middle = (left + right) / 2;

            // Recursively sort the left half
            MergeSort(array, left, middle);

            // Recursively sort the right half
            MergeSort(array, middle + 1, right);

            // Merge the two halves
            Merge(array, left, middle, right);
        }
    }

    public static void Merge(int[] array, int left, int middle, int right)
    {
        // Sizes of two subarrays
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // Temporary arrays
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Copy data into temp arrays
        for (int i = 0; i < n1; i++)
            L[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = array[middle + 1 + j];

        // Merge temp arrays back into original
        int iIndex = 0, jIndex = 0;
        int k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                array[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                array[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        // Copy remaining elements of L[]
        while (iIndex < n1)
        {
            array[k] = L[iIndex];
            iIndex++;
            k++;
        }

        // Copy remaining elements of R[]
        while (jIndex < n2)
        {
            array[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }

    static void LMain(string[] args)
    {
        int[] nums = new int[] { 2, 1, 4, 3, 5 };
        Console.WriteLine("Initial array: " + string.Join(",", nums));
        MergeSort(nums, 0, nums.Length - 1);
        Console.WriteLine("Sorted array: " + string.Join(",", nums));
    }
}

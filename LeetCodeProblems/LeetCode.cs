using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Big_O_notation.LeetCodeProblems
{
    public class LeetCode
    {
        /*
          QUESTION 1: 
          GIVEN A SORTED ARRAY REMOVE DUPLICATES IN-PLACE AND RETURN A NEW LENGTH. 
          SOLVE THIS BY USING TWO POINTER SAME DIRECTION. 
        */
        public static int RemoveDuplicates(int[] array)
        {
            int slow = 1;
            for (int fast = 1; fast < array.Length; fast++)
            {
                if (array[slow - 1] != array[fast])
                {                    
                    array[slow] = array[fast];
                    slow++;
                }
            }
            return slow;
        }
        /*
         QUESTION 2: 
         GIVEN A SORTED ARRAY, A ELEMENT CAN BE REPEATED TWO TIMES.
         REMOVE DUPLICATES FROM SORTED ARRAY II
        */
        public static int RemoveDuplicatesII(int[] array)
        {
            int slow = 2;
            for (int fast = 2; fast < array.Length; fast++)
            {
                if (array[slow - 2] != array[fast])
                {
                    array[slow] = array[fast];
                    slow++;
                }
            }
            return slow;
        }

        public static int[] RemoveDuplicateUnsorted(int[] arr)
        {
            var set = new HashSet<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }
            return set.ToArray();
        }

        public static string RemoveDuplicateFromString(string str)
        {

            var set = new HashSet<char>();
            var input = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (set.Add(str[i]))
                {
                    input += str[i];
                }
            }
            return input;
        }
    }
}

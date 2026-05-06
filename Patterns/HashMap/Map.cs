using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_O_notation.Patterns.HashMap
{
    internal class Map
    {
        private static int[] SumofPairUnsorted(int[] arr, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int result = target - arr[i];
                if (map.ContainsKey(result))
                    return new int[] { map[result], i };
                map[arr[i]] = i;
            }
            return new int[arr.Length];
        }
        private static List<int> RemoveDuplicates(List<int> nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (dictionary.ContainsKey(n))
                    dictionary[n]++;
                else
                    dictionary[n] = 1;
            }
            foreach (var key in dictionary.Keys)
            {
                if (dictionary[key] > 1)
                    nums.Remove(key);
            }
            return nums;
        }
        private static int[] SumofPairHashMap(int[] arr, int target)
        {
            if (arr.Length == 0 || arr.Length < 3)
                return new int[arr.Length];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int otherNumber = target - arr[i];
                if (map.ContainsKey(otherNumber))
                    return new int[] { arr[i], otherNumber };
                map[arr[i]] = i;
            }
            return new int[0];
        }
    }
}

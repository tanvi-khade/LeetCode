using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MedianOfTwoSortedArrays
{
    public class MedianOfTwoSortedArrays
    {
        public static double Solution(int[] nums1, int[] nums2)
        {
            double median = 0;

            // key = the actual value in the arrays, value = index in array
            SortedList<int, int> mergedList = new SortedList<int, int>();
            int newIndex = 0;

            for (int i = 0; i < nums1.Length || i < nums2.Length; i++)
            {
                if (i < nums1.Length)
                    mergedList.Add(nums1[i], nums1[i]);

                if (i < nums2.Length)
                    mergedList.Add(nums2[i], nums2[i]);
            }

            if (mergedList.Count % 2 == 0)
            {
                int index1 = (mergedList.Count / 2);
                int index2 = index1--;
                median = (double)(mergedList.Values.ElementAt(index1) + mergedList.Values.ElementAt(index2)) / 2;
            }
            else
            {
                var x = (decimal)mergedList.Count / 2;
                int index1 = Convert.ToInt32(Math.Ceiling(x)) - 1;

                median = mergedList.Values.ElementAt(index1);

            }

            return median;
        }
    }
}

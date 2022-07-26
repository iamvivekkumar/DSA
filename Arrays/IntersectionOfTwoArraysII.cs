using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class IntersectionOfTwoArraysII
    {
        //Intersection of Two Arrays II

        //Given two integer arrays nums1 and nums2, return an array of their intersection.Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

        //Example 1:
        //Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
        //Output: [2,2]

        //Example 2:
        //Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
        //Output: [4,9]
        //Explanation: [9,4] is also accepted.

        public static int[] DoIntersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return DoIntersect(nums2, nums1);
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> list = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict.ContainsKey(nums1[i]))
                {
                    dict[nums1[i]] = dict[nums1[i]] + 1;
                }
                else
                {
                    dict.Add(nums1[i], 1);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
                {
                    list.Add(nums2[i]);
                    dict[nums2[i]] = dict[nums2[i]] - 1;
                }
            }

            return list.ToArray();

        }
    }
}

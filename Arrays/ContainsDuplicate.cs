using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class ContainsDuplicate
    {
        //Contains Duplicate
        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        //Example 1:
        //Input: nums = [1,2,3,1]
        //Output: true

        //Example 2:
        //Input: nums = [1,2,3,4]
        //Output: false

        //Example 3:
        //Input: nums = [1,1,1,3,3,4,3,2,4,2]
        //Output: true
        public static bool GetContainsDuplicate(int[] nums)
        {
            //Input: nums = [1, 2, 3, 1]
            //Output: true

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return true;
                }

                dict.Add(nums[i], 1);
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class TwoSum
    {
        //        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.




        //Example 1:
        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0,1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

        //Example 2:
        //Input: nums = [3, 2, 4], target = 6
        //Output: [1,2]
        //Example 3:

        //Input: nums = [3, 3], target = 6
        //Output: [0,1]
        public static int[] GetTwoSum(int[] nums, int target)
        {
            //Input: nums = [2, 7, 11, 15], target = 9
            //Output: [0,1]
            //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

            //It turns out we can do it in one-pass.
            //While we are iterating and inserting elements into the hash table, we also look back to check if current element's complement already exists
            //in the hash table. If it exists, we have found a solution and return the indices immediately.
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }                
            }

            return null;
        }
    }
}

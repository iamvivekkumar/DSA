using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class MissingNumberStartWithZero
    {
        //Missing Number
        //Given an array nums containing n distinct numbers in the range[0, n], return the only number in the range that is missing from the array.

        //Example 1:
        //Input: nums = [3, 0, 1]
        //Output: 2
        //Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
        
        //Example 2:
        //Input: nums = [0, 1]
        //Output: 2
        //Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.
        
        //Example 3:
        //Input: nums = [9, 6, 4, 2, 3, 5, 7, 0, 1]
        //Output: 8
        //Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.
        
        public static int MissingNumber(int[] nums)
        {
            int totalSumOfArray = 0;
            int sumWithMissingNum = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                totalSumOfArray += nums[i - 1];
                sumWithMissingNum += i;
            }

            return sumWithMissingNum - totalSumOfArray;
        }
    }
}

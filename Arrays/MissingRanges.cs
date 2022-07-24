using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public static class MissingRanges
    {
        //Missing Ranges
        //You  are given an inclusive range[lower, upper] and a sorted unique integer array nums, where all elements are in the inclusive range.

        //A number x is considered missing if x is in the range[lower, upper] and x is not in nums.

        //Return the smallest sorted list of ranges that cover every missing number exactly.That is, no element of nums is in any of the ranges, and each missing number is in one of the ranges.

        //Each range[a, b] in the list should be output as:

        //"a->b" if a != b
        //"a" if a == b

        //Example 1:
        //Input: nums = [0, 1, 3, 50, 75], lower = 0, upper = 99
        //Output: ["2","4->49","51->74","76->99"]
        //Explanation: The ranges are:
        //[2,2] --> "2"
        //[4,49] --> "4->49"
        //[51,74] --> "51->74"
        //[76,99] --> "76->99"

        //Example 2:
        //Input: nums = [-1], lower = -1, upper = -1
        //Output: []
        //Explanation: There are no missing ranges since there are no missing numbers.

        public static IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            //Input: nums = [0, 1, 3, 50, 75], lower = 0, upper = 99
            //Output:["2","4->49","51->74","76->99"]

            //Input: nums = [-1], lower = -1, upper = -1
            //Output:[]
            IList<string> result = new List<string>();
            int previous = lower - 1;

            for (int i = 0; i <= nums.Length; i++)
            {
                int current = i < nums.Length ? nums[i] : upper + 1;

                if (previous + 1 <= current - 1)
                {
                    result.Add(GetRange(previous + 1, current - 1));
                }

                previous = current;

            }

            return result;

        }

        public static string GetRange(int lower, int upper)
        {
            if (lower == upper)
            {
                return $"{lower}";
            }
            else
            {
                return $"{lower}->{upper}";
            }
        }
    }
}

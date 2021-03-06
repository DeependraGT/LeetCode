﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Solution1
    {
        /*
         
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.

 

        Example 1:

        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        Example 2:

        Input: nums = [3,2,4], target = 6
        Output: [1,2]
        Example 3:

        Input: nums = [3,3], target = 6
        Output: [0,1]
 

        Constraints:

        2 <= nums.length <= 103
        -109 <= nums[i] <= 109
        -109 <= target <= 109
        Only one valid answer exists.


        */


        /// <summary>
        /// Adding to number to get target number
        /// Runtime: 344 ms
        /// Memory Usage: 48.2 MB
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> map = new Dictionary<int, int>();
            int diff = 0;
            int lng = nums.Length;
            for (int i = 0; i < lng; i++)
            {
                diff = target - nums[i];
                if (map.ContainsKey(diff) && i != map[diff])
                    return new int[] { i, map[diff] };

                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }

            return null;

        }

    }
}

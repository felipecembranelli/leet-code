// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

public static class TwoSum {


    // solution brutal force (O(nˆ2) or O(n log n))
    public static string Calculate(int[] nums, int target)
    {
        bool found = false;

        int pos1 = -1, pos2 = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (found)
                break;

            int current = nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = current + nums[j];

                if (sum==target)
                {
                    pos1 = i;
                    pos2 = j;
                    found = true;
                    break;
                }

            }
        }

        return String.Format("[{0},{1}]", pos1.ToString(), pos2.ToString());
    }

    public static string CalculateBrutalForce(int[] nums, int target)
        {

            int i, j = 0;

            for (i = 0; i <= nums.Length - 1; i++)
            {
                for (j = i + 1; j <= nums.Length - 1; j++)
                {

                if ((nums[i] + nums[j]) == target)
                    //return new int[] { i, j };
                    return String.Format("[{0},{1}]", i.ToString(), j.ToString());
                }
            }

            //return new int[] { -1, -1 };
            return "[-1,-1]";
    }
    

    /// <summary>
    /// dictionary solution O(N)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    /*
     * Complexity
            Time: O(N) where N is the number of intergers in the input array.
            We basically just need to traverse the input array one time. Dictioary.Add() and Dictioanry.ContainsKey() are both O(1) operation.

            Space: O(N) where N is the number of intergers in the input array.
            Dictonary stores at most n number of key-value pairs.
     * 
     * 
     * https://leetcode.com/problems/two-sum/discuss/578502/C-O(n)-solution
     */
    public static string Calculate2(int[] nums, int target)
    {

        Dictionary<int, int> dic = new Dictionary<int, int>();

        int index1 = -1;
        int index2 = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];

            if (dic.ContainsKey(target - current))
            {
                index1 = dic[target - current];
                index2 = i;
                break;
            }
            else { 
                dic.Add(current, i);
            }
        }

        return String.Format("[{0},{1}]", index1.ToString(), index2.ToString());
    }
}
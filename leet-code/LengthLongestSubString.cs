
using System;
using System.Collections;

// https://leetcode.com/problems/longest-substring-without-repeating-characters/

public static class LengthOfLongestSubstring
{


    // O(N)
    public static int Solution(string s)
    {
        string output = String.Empty;
        int counter = 0;
        string currentChar = String.Empty;

        string finalOutput = String.Empty;
        int finalCounter = 0;

        if (s.Length == 0)
            return counter;
        else if (s.Length == 1)
        {
            return ++counter;
        }

        currentChar = s[0].ToString();
        output = output + currentChar;
        counter++;

        for (int i = 1; i <= s.Length - 1; i++)
        {

            currentChar = s[i].ToString();

            if (!output.Contains(currentChar))
            {
                counter++;
                output = output + currentChar;

                if (counter > finalCounter)
                {
                    finalOutput = output;
                    finalCounter = counter;
                }

            }
            else
            {
                if (counter > finalCounter)
                {
                    finalOutput = output;
                    finalCounter = counter;
                }

                counter = 1;
                output = currentChar;
            }

        }

        return finalCounter;
    }


    // O(N) - sliding window
    // Use two pointers to check. If right pointer less than s.Length && (s[i]) is not contained in the List,
    // the right pointer will be ++, otherwise the left pointer will be ++. Update MaxLength when right++.
    public static int Solution2(string s)
    {
        int size = s.Length;
        int right = 0;
        int left = 0;
        int maxLength = 0;
        List<char> sub = new List<char>();

        while (right < size)
        {
            if (!sub.Contains(s[right]))
            {
                sub.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, right - left);
            }
            else
            {
                sub.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}
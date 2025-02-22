// See https://aka.ms/new-console-template for more information
using System;

// https://leetcode.com/problems/valid-anagram/
static class Anagram {


    // solution brutal force (O(nˆ2) or O(n log n))
    public static bool IsAnagram(string s, string t)
    {
        bool found = false;

        if (s.Length != t.Length)
            return found;

        for (int i = 0; i < s.Length - 1; i++)
        {

            int current = s[i];

            for (int j = 0; j < t.Length - 1; j++)
            {
                if (t[j] == current)
                {

                    found = true;
                    break;
                }
            }

            if (!found)
                return found;
        }

        return found;
    }

    /// <summary>
    /// It creates a size 26 int arrays as buckets for each letter in alphabet.
    /// It increments the bucket value with String s and decrement with string t.
    /// So if they are anagrams, all buckets should remain with initial value which is zero. So just checking that and return
    /// </summary>
    public static bool IsAnagram2(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        char[] arr = new char[26];
        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a']++; // 'a' is 97.
            arr[t[i] - 'a']--;
        }

        return arr.All(c => c == 0);
    }


    /// <summary>
    /// O(2n) + O(26) Solution faster than 97.71%
    /// </summary>
    public static bool IsAnagram3(string s, string t)
    {
        if (s.Length != t.Length) return false;

        int[] one = new int[26];
        int[] two = new int[26];

        foreach (char ch in s)
        {
            one[ch - 'a']++;
        }

        foreach (char ch in t)
        {
            two[ch - 'a']++;
        }

        for (int i = 0; i < 26; ++i)
        {
            if (one[i] != two[i]) return false;
        }

        return true;
    }
    
}
// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;


//https://leetcode.com/problems/valid-palindrome/

static class Palindrome {


    // O(N)
    public static bool Calculate(string s)
    {


        // traverse string, comparing characteres

        int pointer1 = 0;
        int pointer2 = s.Length-1;

        //s = s.ToLower();


        
        while (pointer1 < pointer2)
        {

            if (!char.IsLetterOrDigit(s[pointer1]))
                pointer1++;

            else if (!char.IsLetterOrDigit(s[pointer2]))
                pointer2--;

            else if (s[pointer1].ToString().ToLower() != s[pointer2].ToString().ToString())
                return false;
            else
            {
                pointer1++;
                pointer2--;
            }
        }

        return true;
    }



}
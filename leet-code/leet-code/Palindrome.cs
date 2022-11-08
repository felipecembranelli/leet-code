// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

static class Palindrome {


    // solution brutal force (O(nˆ2) or O(n log n))
    public static bool Calculate(string s)
    {


        // traverse string, comparing characteres

        int pointer1 = 0;
        int pointer2 = s.Length-1;

        s = s.ToLower();


        while (pointer1 < pointer2)
        {

            if (!char.IsLetterOrDigit(s[pointer1]))
                pointer1++;

            else if (!char.IsLetterOrDigit(s[pointer2]))
                pointer2--;

            else if (s[pointer1] != s[pointer2])
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
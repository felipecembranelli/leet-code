// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

// https://leetcode.com/problems/valid-parentheses/

static class ValidParentheses {


    // O(N)
    public static bool Calculate(string[] s)
    {

        bool isValid = true;
        Stack<string> stackOpen = new Stack<string>();
        
        for (int i = 0; i < s.Length -1; i++)
        {
            // open brackets
            if ((s[i]=="(") || (s[i] == "{") || (s[i] == "["))
            {
                stackOpen.Push(s[i]);
            }
            else
            {
                string topBracket = stackOpen.Pop();

                switch (topBracket)
                {
                    case "(":
                        isValid = s[i] == ")" ? true : false;
                        break;
                    case "{":
                        isValid = s[i] == "}" ? true : false;
                        break;
                    case "[":
                        isValid = s[i] == "]" ? true : false;
                        break;
                }

                if (!isValid)
                    break;

            }
        }

        return isValid;
    }
}
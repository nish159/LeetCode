/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
*/

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var token = s[i];

                if (token == '('|| token == '[' || token == '{')
                {
                    stack.Push(token);
                }
                else // the token is not an opening token - it is a closing token
                {
                    if (stack.Count <= 0)
                    {
                        return false;
                    }

                    var openingToken = stack.Pop();
                    if(openingToken == '(' && token != ')')
                    {
                        return false;
                    }
                    else if (openingToken == '[' && token != ']')
                    {
                        return false;
                    }
                    else if (openingToken == '{' && token != '}')
                    {
                        return false;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;
    }
}

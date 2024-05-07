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

public bool IsValid(string s) {
    Stack<char> stack = new Stack<char>(); // Create a stack to store opening parentheses
    foreach (char c in s) { // Loop through each character in the string
        if (c == '(' || c == '[' || c == '{') { // If it's an opening parenthesis
            stack.Push(c); // Push it onto the stack
        } else if (stack.Count == 0 || // If it's a closing parenthesis and stack is empty or
                   (c == ')' && stack.Peek() != '(') || // current closing doesn't match last opening
                   (c == ']' && stack.Peek() != '[') || 
                   (c == '}' && stack.Peek() != '{')) {
            return false; // Not valid
        } else {
            stack.Pop(); // Pop the matching opening parenthesis
        }
    }
    return stack.Count == 0; // If stack is empty, all parentheses matched
}


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

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

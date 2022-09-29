string str = "racecar";

IsPalindrome(str);

bool IsPalindrome(string str)
{
    // base case; if the string is empty
    if (str == String.Empty)
    {
        return true;
    }

    // start at the beginning of the string 
    int start = 0;
    // start at the end of the string
    int end = str.Length - 1;

    // while the beginning of the string is less than the end of the string
    // if the characters in the middle are the same then the strinrg is a palindrome
    while (start < end)
    {
        if (str[start] == str[end])
        {
            // increment the beginning of the string by 1
            start++;
            // decrement the end of the string by 1
            end--;
        }
        else
        {
            Console.WriteLine($"{str} is not a palindrome");
            return false;
        }
    }
    Console.WriteLine($"{str} is a palindrome");

    return true;
}

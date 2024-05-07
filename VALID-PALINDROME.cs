/*
CHECK IF STRING IS A VALID PALINDROME
*/

string str = "racecar";

IsPalindrome(str);

bool IsPalindrome(string str)
{
    // Base case: if the string is empty, it is considered a palindrome
    if (str == String.Empty)
    {
        return true;
    }

    // Initialize variables for the start and end of the string
    int start = 0;  // Start at the beginning of the string
    int end = str.Length - 1;  // Start at the end of the string

    // Iterate until the start index is less than the end index
    while (start < end)
    {
        if (str[start] == str[end])  // If characters at start and end are the same
        {
            start++;  // Move start index forward
            end--;  // Move end index backward
        }
        else  // If characters are not the same, the string is not a palindrome
        {
            Console.WriteLine($"{str} is not a palindrome");
            return false;
        }
    }

    // If the loop completes without returning false, the string is a palindrome
    Console.WriteLine($"{str} is a palindrome");
    return true;
}


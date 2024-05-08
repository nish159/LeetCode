// WRITE A FUNCTION TO FIND THE FIRST NON-REPEATING CHARACTER IN A STRING

// Function to find the first non-repeating character
public static char FirstNonRepeatingChar(string str)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach (char c in str)
    {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }

    foreach (char c in str)
    {
        if (charCount[c] == 1)
            return c;
    }

    return '\0'; // Return null character if no non-repeating character found
}

// Example usage
string inputString = "leetcode";
char firstNonRepeating = FirstNonRepeatingChar(inputString);
Console.WriteLine(firstNonRepeating); // Output: 'l'

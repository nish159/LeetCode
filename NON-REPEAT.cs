// WRITE A FUNCTION TO FIND THE FIRST NON-REPEATING CHARACTER IN A STRING

// Function to find the first non-repeating character in a string
public static char FirstNonRepeatingChar(string str)
{
    // Create a dictionary to store character frequencies
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    // Count the frequency of each character in the input string
    foreach (char c in str)
    {
        if (charCount.ContainsKey(c)) // Check if the character already exists in the dictionary
            charCount[c]++; // Increment the count if the character is already present
        else
            charCount[c] = 1; // Initialize the count to 1 for a new character
    }

    // Iterate through the input string again to find the first non-repeating character
    foreach (char c in str)
    {
        if (charCount[c] == 1) // Check if the character occurs only once in the string
            return c; // Return the first non-repeating character found
    }

    return '\0'; // Return null character if no non-repeating character is found
}

// Example usage
string inputString = "leetcode";
char firstNonRepeating = FirstNonRepeatingChar(inputString);
Console.WriteLine(firstNonRepeating); // Output: 'l'


/*
CONSTRAINTS:
INPUT SHOULD NOT BE NULL 
INPUT STRING CAN CONTAIN ANY INICODE CHARACTERS
*/

// Function to find the first non-repeating character
public static char FirstNonRepeatingChar(string str)
{
    // Check if the input string is not null
    if (str == null)
    {
        throw new ArgumentNullException(nameof(str), "Input string cannot be null.");
    }

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

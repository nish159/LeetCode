// WRITE A FUNCTION TO REVERSE A STRING

// Function to reverse a string without using Array.Reverse
public static string ReverseStringWithoutArrayReverse(string str)
{
    // Convert the input string to a character array
    char[] charArray = str.ToCharArray();

    // Get the length of the character array
    int length = charArray.Length;

    // Initialize variables for swapping characters
    int left = 0;
    int right = length - 1;

    // Loop through the character array until the pointers meet
    while (left < right)
    {
        // Swap the characters at the left and right positions
        char temp = charArray[left];
        charArray[left] = charArray[right];
        charArray[right] = temp;

        // Move the left pointer forward and the right pointer backward
        left++;
        right--;
    }

    // Convert the reversed character array back to a string
    return new string(charArray);
}


// Function to reverse a string
public static string ReverseString(string str)
{
    // Convert the input string to a character array
    char[] charArray = str.ToCharArray();

    // Reverse the character array using the Array.Reverse method
    Array.Reverse(charArray);

    // Convert the reversed character array back to a string
    return new string(charArray);
}

// Example usage
string originalString = "Hello World!";
string reversedString = ReverseString(originalString); // Call the ReverseString function
Console.WriteLine(reversedString); // Output: "!dlroW olleH"


/*
INPUT SHOULD NOT BE NULL 
INPUT STRING CAN CONTAIN ANY UNICODE CHARACTERS
*/

// Function to reverse a string
public static string ReverseString(string str)
{
    // Check if the input string is not null
    if (str == null)
    {
        throw new ArgumentNullException(nameof(str), "Input string cannot be null.");
    }

    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

// Example usage
string originalString = "Hello World!";
string reversedString = ReverseString(originalString);
Console.WriteLine(reversedString); // Output: "!dlroW olleH"

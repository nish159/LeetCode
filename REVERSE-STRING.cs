// Function to reverse a string
public static string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

// Example usage
string originalString = "Hello World!";
string reversedString = ReverseString(originalString);
Console.WriteLine(reversedString); // Output: "!dlroW olleH"

/*
Given a string s, return true if s is a good string, or false otherwise.
A string s is good if all the characters that appear in s have the same number of occurrences (i.e., the same frequency).

Example 1:

Input: s = "abacbc"
Output: true
Explanation: The characters that appear in s are 'a', 'b', and 'c'. All characters occur 2 times in s.

Example 2:
Input: s = "aaabb"
Output: false
Explanation: The characters that appear in s are 'a' and 'b'.
'a' occurs 3 times while 'b' occurs 2 times, which is not the same number of times.

Constraints:
1 <= s.length <= 1000
s consists of lowercase English letters.
*/

public class Solution {
    public bool AreOccurrencesEqual(string s) {
        // Create a dictionary to store character occurrences
        Dictionary<char, int> result = new Dictionary<char, int>();
        
        // Iterate through the input string
        for (int i = 0; i < s.Length; i++) {
            // Get the current character
            var currentChar = s[i];
            
            // Check if the dictionary already contains the character
            if (result.ContainsKey(currentChar)) {
                // If yes, increment its count by 1
                result[currentChar]++;
            }
            else {
                // If no, add the character to the dictionary with a count of 1
                result.Add(currentChar, 1);
            }
        }
        
        // Get the count of occurrences of the first character in the dictionary
        int count = result.First().Value;
        
        // Check if all characters in the dictionary have the same count
        foreach (KeyValuePair<char, int> entry in result) {
            // If any character has a different count, return false
            if (count != entry.Value) {
                return false;
            }
        }
        // All characters have the same count, so return true
        return true;
    }
}

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
        // need a dictionary to store key = char and value = count
        Dictionary<char, int> result = new Dictionary<char, int>();
        
        for (int i = 0; i < s.Length; i++) {
            // variable for the current character 
            var currentChar = s[i];
            // if dictionary contains the key increment value by 1
            if (result.ContainsKey(currentChar)) {
                result[currentChar]++;
            }
            else {
                // if it does not add key to the dictionary with a value of 1
                result.Add(currentChar, 1);
            }
        }
        
        // count the first value in the dictionary
        int count = result.First().Value;
        
        // loop through the dictionary
        foreach (KeyValuePair<char, int> entry in result) {
            // if the count is != to the value in the dictionary return false
            if (count != entry.Value) {
                return false;
            }
        }
        return true;
    }
}

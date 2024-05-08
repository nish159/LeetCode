/*
You are given the strings key and message, which represent a cipher key and a secret message, respectively. 
The steps to decode message are as follows:
Use the first appearance of all 26 lowercase English letters in key as the order of the substitution table.
Align the substitution table with the regular English alphabet.
Each letter in message is then substituted using the table.
Spaces ' ' are transformed to themselves.
For example, given key = "happy boy" (actual key would have at least one instance of each letter in the alphabet), 
we have the partial substitution table of ('h' -> 'a', 'a' -> 'b', 'p' -> 'c', 'y' -> 'd', 'b' -> 'e', 'o' -> 'f').
Return the decoded message.

Example 1:
Input: key = "the quick brown fox jumps over the lazy dog", message = "vkbs bs t suepuv"
Output: "this is a secret"
Explanation: The diagram above shows the substitution table.
It is obtained by taking the first appearance of each letter in "the quick brown fox jumps over the lazy dog".

Example 2:
Input: key = "eljuxhpwnyrdgtqkviszcfmabo", message = "zwx hnfx lqantp mnoeius ycgk vcnjrdb"
Output: "the five boxing wizards jump quickly"
Explanation: The diagram above shows the substitution table.
It is obtained by taking the first appearance of each letter in "eljuxhpwnyrdgtqkviszcfmabo".
 

Constraints:
26 <= key.length <= 2000
key consists of lowercase English letters and ' '.
key contains every letter in the English alphabet ('a' to 'z') at least once.
1 <= message.length <= 2000
message consists of lowercase English letters and ' '.
*/

public class Solution {
    public string DecodeMessage(string key, string message) {
        // Create a dictionary to map characters from the key to letters 'a' onwards
        Dictionary<char, char> dictionary = new Dictionary<char, char>();
        
        // Initialize a letter variable starting from 'a'
        char letter = 'a';
        // Initialize the result string
        string result = "";
        
        // Populate the dictionary with mappings from key characters to letters
        for (int i = 0; i < key.Length; i++) {
            // Check if the character is not already in the dictionary and is not a space
            if (!dictionary.ContainsKey(key[i]) && key[i] != ' ') {
                dictionary.Add(key[i], letter);
                letter++;
            }
        }
        
        // Decode the message using the dictionary
        for (int i = 0; i < message.Length; i++) {
            // If the character exists in the dictionary, append its mapped value to the result
            if (dictionary.ContainsKey(message[i])) {
                char value = dictionary[message[i]];
                result += value;
            }
            
            // If the character is a space, append a space to the result
            if (message[i] == ' ') {
                result += ' ';
            }
        }
        
        // Uncomment the following block to print the dictionary entries
        /*
        foreach (KeyValuePair<char, char> entry in dictionary) {
            Console.WriteLine(entry.Key + ":" + entry.Value);
        }
        */
        
        return result;
    }
}

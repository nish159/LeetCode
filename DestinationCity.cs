/*
You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. 
Return the destination city, that is, the city without any path outgoing to another city.
It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.

Example 1:
Input: paths = [["London","New York"],["New York","Lima"],["Lima","Sao Paulo"]]
Output: "Sao Paulo" 
Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city. 
Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".

Example 2:
Input: paths = [["B","C"],["D","B"],["C","A"]]
Output: "A"
Explanation: All possible trips are: 
"D" -> "B" -> "C" -> "A". 
"B" -> "C" -> "A". 
"C" -> "A". 
"A". 
Clearly the destination city is "A".

Example 3:
Input: paths = [["A","Z"]]
Output: "Z"

Constraints:
1 <= paths.length <= 100
paths[i].length == 2
1 <= cityAi.length, cityBi.length <= 10
cityAi != cityBi
All strings consist of lowercase and uppercase English letters and the space character.
*/

public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        // Create a dictionary to store city-destination pairs
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        // Loop through the list of paths
        for (int i = 0; i < paths.Count; i++) {
            // Get the current city and destination from the path
            var currentCity = paths[i][0];
            var destCity = paths[i][1];
            
            // If the current city is not in the dictionary, add it with a value of 1
            if (!dictionary.ContainsKey(currentCity)) {
                dictionary.Add(currentCity, 1);
            }
            else {
                // If the city is already in the dictionary, increment its value by 1
                dictionary[currentCity]++;
            }
            
            // If the destination city is not in the dictionary, add it with a value of 0
            if (!dictionary.ContainsKey(destCity)) {
                dictionary.Add(destCity, 0);
            }
        }
        
        // Loop through the dictionary to find the destination city with a value of 0
        foreach (KeyValuePair<string, int> entry in dictionary) {
            // If the value is 0, return the key (destination city)
            if (entry.Value == 0) {
                return entry.Key;
            }
        }
        
        // If no destination city with a value of 0 is found, return an empty string
        return "";
    }
}


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
        // create dictionary to store key/values
        // key = city
        // value = destination
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        // loop through the array
        for (int i = 0; i < paths.Count; i++) {
            // variable for the current city
            var currentCity = paths[i][0];
            var destCity = paths[i][1];
            
            // if the current city is not in the dictionary add the city 
            // its the first time we are seeing the city so the value will be 1
            if (!dictionary.ContainsKey(currentCity)) {
                dictionary.Add(currentCity, 1);
            }
            else {
            // increment the value by 1
                dictionary[currentCity]++;
            }
            
            // if the dictionary does not contain the destination add the destination 
            // this is the count of the destination so it will be set a value of 0
            if (!dictionary.ContainsKey(destCity)) {
                dictionary.Add(destCity, 0);
            }
        }
        
        // loop through the dictionary
        foreach (KeyValuePair<string, int> entry in dictionary) {
        // if the key value is eq to 0 then return the key
            if (entry.Value == 0) {
                return entry.Key;
            }
        }
        // return an empty stirng 
        return "";
    }
}

public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        map.Add('I',1);
        map.Add('V',5);
        map.Add('X',10);
        map.Add('L',50);
        map.Add('C',100);
        map.Add('D',500);
        map.Add('M',1000);
        
        int number = 0;
        
        for (int i = 0; i < s.Length; i++){
        
            if( i == s.Length - 1)
            {
                // We are processing the last character in the string
                number = number += map[s[i]];
            }
            else
            {
                // We are not processing the last character,
                // we need to determine if the current value should
                // be added or substracted from the number
                int currentValue = map[s[i]];
                int nextValue = map[s[i + 1]];

                if (currentValue < nextValue){

                    number = number - currentValue;
                }
                else{
                    number = number + currentValue;
                }
            }
            
        }
        return number;
    }
}

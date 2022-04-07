public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dictionary.ContainsKey(nums[i]))
            {
                return new int[]{dictionary[nums[i]], i};               
            }
            else if(!dictionary.ContainsKey(target - nums[i]))
            {
                dictionary.Add(target -nums[i], i);                  
            }          
        }        
        return new int[]{0, nums.Length};
    }
}

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
       Dictionary<int, int> map = new Dictionary<int, int>();
        
        // Create the map
        for(int i = 0 ; i < nums.Length; i++)
        {
            map.Add(nums[i], i);
        }
        foreach(var kvPair in map)
        {
            Console.WriteLine($"{kvPair.Key}:{kvPair.Value}");
        }
        
        for(int i = 0; i < nums.Length; i++){
            int number = nums[i];
            int x = target - number;
            
            if (number != x && map.ContainsKey(x)){
                return new int[]{i, map[x]};
            }
        }
        return null;
           
      }
}

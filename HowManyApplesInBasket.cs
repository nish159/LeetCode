/*
You have some apples and a basket that can carry up to 5000 units of weight.

Given an integer array weight where weight[i] is the weight of the ith apple, return the maximum
number of apples you can put in the basket.

Example 1
Input: weight = [100, 200, 150, 1000]
Output: 4
Explanation: All 4 apples can be carried by the basket since their sum of weights is 1450.

Example 2
Input: weight = [900, 950, 800, 1000, 700, 800]
Output: 5
Explanation: The sum of weights of the 6 apples exceeds 5000 so we choose any 5 of them.

Constraints:
1 <= weight.Length <= 10^3
1 <= weight[1] <= 10^3
*/

int[] weight = { 100, 200, 150, 1000 };
//int[] weight2 = { 900, 950, 800, 1000, 700, 800 };

int MaxNumberOfApples(int[] weight)
{
    // Sort the array in ascending order
    Array.Sort(weight);

    // Maximum weight the bag can hold
    int max = 5000;

    // Sum of weights of apples added to the bag
    int sum = 0;

    // Number of apples that can fit into the bag
    int count = 0;

    // Loop through the sorted array of apple weights
    for (int i = 0; i < weight.Length; i++)
    {
        // Add the weight of the current apple to the sum
        sum += weight[i];

        // If the current sum is less than or equal to the maximum weight allowed
        if (sum <= max)
        {
            // Increment the count of apples that can fit
            count++;
        }
        // If the current sum exceeds the maximum weight allowed
        else if (sum > max)
        {
            // Break the loop as no more apples can be added to the bag
            break;
        }
    }

    return count; // Return the maximum number of apples that can fit into the bag
}


    return count;
}

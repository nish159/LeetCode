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
    // sort the array
    Array.Sort(weight);

    // max weight
    int max = 5000;

    // sum of apples 
    int sum = 0;

    // how many apples can fit
    int count = 0;

    // loop through array
    for (int i = 0; i < weight.Length; i++)
    {
        // add weight
        sum = sum + weight[i];

        // if sum is less than max weight
        if (sum <= max)
        {
            count++;
        }
        // if sum is greater than max weight
        else if (sum > max)
        {
            break;
        }
    }

    return count;
}

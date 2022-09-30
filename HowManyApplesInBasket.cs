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

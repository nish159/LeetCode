/*
You are given a large integer represented as an integer array digits, where each digits[i]
is the ith digit of the integer. The digits are ordered from most significant to least 
significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

Example 1
Input: digits = [1,2,3]
Output: [1,2,4]
Explaination: The array represents the integer 123. Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].

Example 2
Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explaination: The array represents the integer 4321. Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].

Example 3
Input: [9]
Output: [1,0]
Explaination: The array represents an integer of 9. Increment by one gives 9 + 1 = 10.
Thus, the result should be [1,0].

Constraints:
1 <= digits.length <= 100
0 <= digits[i] <= 9
digits does not contain any leading 0's
*/

int[] PlusOne(int[] digits)
{
	// loop will start at the end of the array instead of the beginning
	for (int i = digits.Length - 1; i >= 0; i--)
	{
		// if the index in digits equals 9 then the new value will 
		// be set to 0 because 9 + 1 = 10
		if (digits[i] == 9)
		{
			digits[i] = 0;
		}
		else
		{
			digits[i]++;
			return digits;
		}
	}
	
	// if all the numbers in the array are [9,9,9] after loop it will
	// become [0,0,0] so a new array is created and starts at 1
	int[] newArr = new int[digits.Length + 1];
	newArr[0] = 1;

	return newArr;
}

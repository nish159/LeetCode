/*
Given an integer x, return true if x is palindrome integer.
An integer is a palindrome when it reads the same backward as forward.
	• For example, 121 is a palindrome while 123 is not.
 
Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 
Constraints:
	• -231 <= x <= 231 - 1
 
Follow up: Could you solve it without converting the integer to a string?
*/

public class Solution {
    public bool IsPalindrome(int x) {
        
    if (x == 0)
	return true;

	if (x < 0 || x % 10 == 0)
		return false;

	int reverseNum = 0;

	while (x > reverseNum)
	{
		reverseNum = reverseNum * 10 + x % 10;
		x /= 10;
	}

	return x == reverseNum || x == reverseNum / 10;
    }
}

/*
// Time complexity O(n)
int x = 400;

IsPalindrome(x);

bool IsPalindrome(int x)
{
	// base case
	if (x == 0)
	{
		return true;
	}

	// if number is negative
	if (x < 0)
	{
		return false;
	}

	// store the last digit
	int lastDigit = 0;
	// store the reverse number
	int reverse = 0;
	// making a copy of x so we don't overwrite the conditional statement
	int number = x;

	// loop through the numbers
	// when we reach 0 we are done
	while (number != 0)
	{
		lastDigit = number % 10;
		number = number / 10;
		reverse = reverse * 10 + lastDigit;
	}

	// if the reverse number is equal to the current number return true
	// return false if it does not equal
	if (reverse == x)
	{
        Console.WriteLine($"{x} is a palindrome");
        return true;
    }
    Console.WriteLine($"{x} is not a palindrome");
    return false;
}
*/

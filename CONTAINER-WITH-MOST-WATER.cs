/*
FIND THE CONTAINER WITH THE MOST WATER GIVEN A LIST OF HEIGHTS

Input: [1,8,6,2,5,4,8,3,7]
Output: 49

*/

public int MaxArea(int[] height) {
    int maxArea = 0; // Initialize max area
    int left = 0, right = height.Length - 1; // Initialize left and right pointers
    while (left < right) { // Until pointers meet
        maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left)); // Update max area
        if (height[left] < height[right]) { // Move pointer with smaller height
            left++;
        } else {
            right--;
        }
    }
    return maxArea; // Return max area found
}

public class Solution {
    public int PivotIndex(int[] nums) {
        int a = nums.Sum();
        int b = 0;

        // Simple loop through the array to find the index.
        for (int i = 0; i < nums.Length; i++) {

            // Remove value from the max.
            a -= nums[i];
            // If the value matches, return the index.
            if (a == b) {
                return i;
            }
            // Add the value to the new sum.
            b += nums[i];
        }

        // If nothing is found, return -1.
        return -1;
    }
}

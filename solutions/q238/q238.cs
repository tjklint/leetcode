public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int[] result = new int[nums.Length];

        left[0] = 1;
        right[nums.Length - 1] = 1;

        for(int i = 1; i < nums.Length; i++) {
            left[i] = nums[i - 1] * left[i - 1];
        }

        for(int i = nums.Length - 2; i >= 0; i--) {
            right[i] = nums[i+1]*right[i+1];
        }

        for(int i = 0; i < nums.Length; i++) {
            result[i] = left[i]*right[i];
        }

        return result;
    }
}

public class Solution {
    public int MaxOperations(int[] nums, int k) {
        // Edge case
        if (nums == null || nums.Length == 0){
            return 0;
        }
        
        // Decl. Vars
        int operations = 0;
        int start = 0;
        int end = nums.Length - 1;

        // Solution
        Array.Sort(nums);
        while (start < end) {
            if (nums[start] + nums[end] == k) {
                operations++;
                start++;
                end--;
            }
            else if (nums[start] + nums[end] < k){
                start++;
            }
            else {
                end--;
            }
        }

        return operations;
    }
}

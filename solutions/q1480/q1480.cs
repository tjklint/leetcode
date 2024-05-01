public class Solution {
    public int[] RunningSum(int[] nums) {
        int runningSum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            runningSum += nums[i];
            nums[i] = runningSum;
        }
        return nums;
    }
}

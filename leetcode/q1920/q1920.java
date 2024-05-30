class Solution {
    public int[] buildArray(int[] nums) {
        int[] answerArr = new int[nums.length];

        for (int i = 0; i < nums.length; ++i){
            answerArr[i] = nums[nums[i]];
        }

        return answerArr;
    }
}

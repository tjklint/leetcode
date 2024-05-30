class Solution {
    public int[] getConcatenation(int[] nums) {
        int[] resultArr = new int[2 * nums.length];
        for (int i = 0; i < resultArr.length; i++) {
            resultArr[i] = nums[i % nums.length];
        }
        return resultArr;

    }
}

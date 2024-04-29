class Solution {
    fun increasingTriplet(nums: IntArray): Boolean {
        var min = Int.MAX_VALUE
        var target = Int.MAX_VALUE

        for (i in nums.indices) {
            val n = nums[i]
            if (n > target) {
                return true
            }
            if (n > min) {
               target = n 
            }
            if (n < min) {
                min = n
            } 
        }

        return false

    }
}

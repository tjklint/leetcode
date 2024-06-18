func numIdenticalPairs(nums []int) int {
    var sol int = 0

    for i := 0; i < len(nums) - 1; i++ {
        for j := i + 1; j < len(nums); j++ {
            if nums[i] == nums[j] {
                sol++
            }
        }
    }

    return sol
}

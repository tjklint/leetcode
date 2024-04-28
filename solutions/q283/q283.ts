/**
 Do not return anything, modify nums in-place instead.
 */
function moveZeroes(nums: number[]): void {
    let wPointer = 0;
    for (let rPointer = 0; rPointer < nums.length; rPointer++) {
        const val = nums[rPointer];
        nums[rPointer] = 0;
        if (val !== 0) {
            nums[wPointer] = val;
            wPointer++
        }
    }
};

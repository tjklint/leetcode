function findMaxAverage(nums: number[], k: number): number {
    let sum: number = 0;
    let maxSum: number = 0;

    for (let i: number = 0; i < nums.length;) {
        sum += nums[i];

        if (i < k) {
            maxSum = sum;
        }
        else {
            sum -= nums[i - k];
            maxSum = Math.max(sum, maxSum);
        }

        i++;
    }

    return maxSum / k;
};

class Solution:
    def minCostClimbingStairs(self, cost: List[int]) -> int:
        length = len(cost) + 1
        answer = [0] * length

        for i in range(2, length): 
            answer[i] = min(answer[i - 1] + cost[i - 1], answer[i -2] + cost[i - 2])
        return answer[length - 1] 
        

class Solution:
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        maxWealth = 0
        for i in accounts:
            tot = 0
            for j in i:
                tot += j
                if tot > maxWealth:
                    maxWealth = tot
        return maxWealth

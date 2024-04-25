class Solution:
    def tribonacci(self, n: int) -> int:
        if n == 0: 
            return 0
        if n == 1 or n == 2:
            return 1

        tribArr = [0, 1, 1]
        i: int = 3
        
        for i in range(3, n + 1):
            tribArr.append(tribArr[i - 3] + tribArr[i - 2] + tribArr[i - 1])

        return tribArr[n]
        

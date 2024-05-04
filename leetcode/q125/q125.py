class Solution:
    def isValid(self, c: str) -> bool:
        return c.isdigit() or c.isalpha()
    
    def isPalindrome(self, s: str) -> bool:
        s = s.strip().lower()
        i : int = 0
        j = len(s) - 1

        while i < j:
            if s[i] == s[j]:
                i += 1
                j -= 1
            else:
                left = self.isValid(s[i])
                right = self.isValid(s[j])

                if left and right:
                    return False
                if not left:
                    i += 1
                if not right:
                    j -= 1
        
        return True
        

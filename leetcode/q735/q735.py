class Solution:
    def asteroidCollision(self, asteroids: List[int]) -> List[int]:
        stack = []
        for asteroid in asteroids:
            if asteroid > 0:
                stack.append(asteroid)
            else: 
                while stack and stack[-1] > 0:
                    if stack[-1] + asteroid == 0:
                        stack.pop()
                        break
                    if stack[-1] + asteroid < 0:
                        stack.pop()
                        continue
                    else:
                        break
                else: 
                    stack.append(asteroid)
        return stack

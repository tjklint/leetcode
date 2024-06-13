# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        # Edge Case: No root
        if not root: return []
        
        queue = deque()
        queue.append(root)

        ans: List = []

        while queue:
            new_queue = deque([])
            node: TreeNode = TreeNode()

            while queue:
                node = queue.popleft()
                if node.left:
                    new_queue.append(node.left)
                if node.right:
                    new_queue.append(node.right)
            
            ans.append(node.val)
            queue = new_queue.copy()

        return ans
            
        
        

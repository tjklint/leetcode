# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from collections import deque

class Solution:
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        # Add the root nodes.
        queue = deque([(p, q)])  
        
        while queue:
            # Pop the root nodes for comparison.
            node1, node2 = queue.popleft()  
            
            # If both nodes are None, continue without doing anything
            if not node1 and not node2:
                continue
            
            # If one of them is None and the others it not, or their values are not equal
            if not node1 or not node2 or node1.val != node2.val:
                return False
            
            # Enqueue children
            queue.append((node1.left, node2.left))
            queue.append((node1.right, node2.right))
        
        # If all comparisons have passed, the trees are the same
        return True

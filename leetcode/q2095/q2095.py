# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        # Test Case 1: 1 Element
        if (head.next == None):
            return None

        # Test Case 2: 2 Elements
        if (head.next.next == None):
            head.next = None
            return head
        
        skip: bool = True
        mid: Optional[ListNode] = head
        end: Optional[ListMode] = head.next

        while end.next != None:
            if (skip == False):
                mid = mid.next
                skip = True
            else:
                skip = False
        
            end = end.next

        mid.next = mid.next.next
        return head

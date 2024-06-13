/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode deleteMiddle(ListNode head) {
        // Edge Case 1: 1 Element.
        if (head.next == null) {
            return null;
        }

        // Edge Case 2: 2 elements, remove element 2, return element 1.
        if (head.next.next == null) {
            head.next = null;
            return head;
        }

        ListNode half = head;
        ListNode end = head.next;
        boolean skip = true;

        while (end.next != null) {
            if (!skip) {
                half = half.next;
                skip = true;
            }
            else {
                skip = false;
            }
            end = end.next;
        }

        half.next = half.next.next;
        return head;
    }
}

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
    public ListNode removeNthFromEnd(ListNode head, int n) {
        ListNode curr = head;
        ListNode dummy = new ListNode(0, head);
        while (curr != null && n > 0) {
            curr = curr.next;
            n--;
        }
        ListNode slow = dummy;
        while (curr != null) {
            slow = slow.next;
            curr = curr.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}

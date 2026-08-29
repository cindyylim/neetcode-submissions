/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
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

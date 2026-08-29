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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        while (l1 != null || l2 != null || carry != 0) {
            int l1val = l1 == null ? 0 : l1.val;
            int l2val = l2 == null ? 0 : l2.val;
            int total = (l1val + l2val + carry);
            int value = total % 10;
            carry = total / 10;
            curr.next = new ListNode(value);
            l1 = l1 == null ? null : l1.next;
            l2 = l2 == null ? null : l2.next;
            curr = curr.next;
        }
        return dummy.next;
    }
}

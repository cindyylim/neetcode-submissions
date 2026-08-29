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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>(); 
        foreach (ListNode node in lists){
            if (node != null) {
                pq.Enqueue(node, node.val);
            }
        }
        ListNode dummy = new ListNode();
        ListNode curr = dummy;
        while (pq.Count > 0) {
            ListNode node = pq.Dequeue();
            if (node.next != null) {
                pq.Enqueue(node.next, node.next.val);
            }
            curr.next = node;
            curr = curr.next;
        }
        return dummy.next;
    }
}

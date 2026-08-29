/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        Node curr = head;
        while (curr != null) {
            oldToNew[curr] = new Node(curr.val);
            curr = curr.next;
        }
        curr = head;
        while (curr != null) {
            Node newNode = oldToNew[curr];
            newNode.random = curr.random == null ? null : oldToNew[curr.random];
            newNode.next = curr.next == null ? null : oldToNew[curr.next];
            curr = curr.next;
        }
        return oldToNew[head];
     }
}

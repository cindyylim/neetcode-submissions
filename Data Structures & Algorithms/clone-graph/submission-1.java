/*
Definition for a Node.
class Node {
    public int val;
    public List<Node> neighbors;
    public Node() {
        val = 0;
        neighbors = new ArrayList<Node>();
    }
    public Node(int _val) {
        val = _val;
        neighbors = new ArrayList<Node>();
    }
    public Node(int _val, ArrayList<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

class Solution {
    public Node cloneGraph(Node node) {
        if (node == null) {
            return null;
        }
        Map<Node, Node> oldToNew = new HashMap<>();
        return dfs(oldToNew, node);
    }
    private Node dfs(Map<Node, Node> oldToNew, Node node) {
        if (oldToNew.containsKey(node)) {
            return oldToNew.get(node);
        }
        Node newNode = new Node(node.val);
        oldToNew.put(node, newNode);
        for (Node neighbor: node.neighbors) {
            newNode.neighbors.add(dfs(oldToNew, neighbor));
        }
        return newNode;
    }
}
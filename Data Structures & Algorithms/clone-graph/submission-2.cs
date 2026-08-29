/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) {
            return null;
        }
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        return Dfs(oldToNew, node);
    }
    private Node Dfs(Dictionary<Node, Node> map, Node node) {
        if (map.ContainsKey(node)){
            return map[node];
        }
        Node newNode = new Node(node.val);
        map[node] = newNode;
        foreach(Node n in node.neighbors) {
            newNode.neighbors.Add(Dfs(map, n));
        }
        return newNode;
    }
}

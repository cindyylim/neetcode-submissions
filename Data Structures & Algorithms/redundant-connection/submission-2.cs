public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int[] parent = new int[edges.Length + 1];
        int[] rank = new int[edges.Length + 1];
        for(int i = 0; i < parent.Length; i++) {
            parent[i] = i;
        }
        foreach(int[] edge in edges){
            int a = edge[0];
            int b = edge[1];
            if (!union(a, b, parent, rank)){
                return edge;
            }
        }
        return new int[0];
    }
    private bool union(int a, int b, int[] parent, int[] rank) {
        int rootA = findParent(a, parent);
        int rootB = findParent(b, parent);
        if (rootA == rootB) {
            return false;
        }
        if (rank[rootA] < rank[rootB]){
            parent[rootA] = rootB;
        }else if (rank[rootA] > rank[rootB]){
            parent[rootB] = rootA;
        }else {
            parent[rootB] = rootA;
            rank[rootA]++;
        }
        return true;
    }
    private int findParent(int node, int[] parent) {
        if (parent[node] != node) {
            parent[node] = findParent(parent[node], parent);
        }
        return parent[node];
    }
}

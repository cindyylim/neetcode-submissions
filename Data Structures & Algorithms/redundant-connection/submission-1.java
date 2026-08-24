class Solution {
    public int[] findRedundantConnection(int[][] edges) {
        int[] parent = new int[edges.length + 1];
        int[] rank = new int[edges.length + 1];
        for (int i =0; i <= edges.length; i++) {
            parent[i] = i;
        }
        for (int[] edge: edges) {
            int a = edge[0];
            int b = edge[1];
            if (!union(a, b, parent, rank)) {
                return edge;
            }
        }
        return new int[0];
    }
    private boolean union(int a, int b, int[] parent, int[] rank) {
        int rootA = findParent(a, parent);
        int rootB = findParent(b, parent);
        if (rootA == rootB){
            return false;
        }
        if (rank[rootA] < rank[rootB]) {
            parent[rootA] = rootB;
        }else if (rank[rootA] > rank[rootB]) {
            parent[rootB] = rootA;
        }else {
            parent[rootB] = rootA;
            rank[rootA]++;
        }
        return true;
    }
    private int findParent(int x, int[] parent) {
        if (parent[x] != x) {
            parent[x] = findParent(parent[x], parent);
        }
        return parent[x];
    }
}

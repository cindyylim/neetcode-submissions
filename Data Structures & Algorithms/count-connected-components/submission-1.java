class Solution {
    public int countComponents(int n, int[][] edges) {
        List<List<Integer>> graph = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            graph.add(new ArrayList<>());
        }
        for (int[] edge : edges) {
            int from = edge[0];
            int to = edge[1];
            graph.get(from).add(to);
            graph.get(to).add(from);
        }
        boolean[] visited = new boolean[n];
        int numComponents = 0;
        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                dfs(visited, i, graph);
                numComponents++;
            }
        }
        return numComponents;
    }
    private void dfs(boolean[] visited, int node, List<List<Integer>> graph) {
        if (visited[node]) {
            return;
        }
        visited[node] = true;
        for (int neighbor: graph.get(node)) {
            dfs(visited, neighbor, graph);
        }
    }
}

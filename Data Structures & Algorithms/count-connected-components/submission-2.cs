public class Solution {
    public int CountComponents(int n, int[][] edges) {
        List<List<int>> graph = new List<List<int>>();
        HashSet<int> visited = new HashSet<int>();
        for (int i = 0; i < n; i++) {
            graph.Add(new List<int>());
        }
        foreach(int[] edge in edges) {
            int from = edge[0];
            int to = edge[1];
            graph[from].Add(to);
            graph[to].Add(from);
        }
        int numComponents = 0;
        for (int i = 0; i < n; i++) {
            if (visited.Contains(i)){
                continue;
            }
            Dfs(i, visited, graph);
            numComponents++;
        }
        return numComponents;
    }
    private void Dfs(int node, HashSet<int> visited, List<List<int>> graph) {
        if (visited.Contains(node)) {
            return;
        }
        visited.Add(node);
        List<int> neighbors = graph[node];
        foreach(int n in neighbors) {
            Dfs(n, visited, graph);
        }
    }
}

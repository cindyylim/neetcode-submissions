public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1) {
            return false;
        }
        HashSet<int> visited = new HashSet<int>();
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i < n; i++) {
            graph.Add(new List<int>());
        }
        foreach(int[] edge in edges) {
            int from = edge[0];
            int to = edge[1];
            graph[from].Add(to);
            graph[to].Add(from);
        }
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);
        while (queue.Count > 0) {
            int node = queue.Dequeue();
            if (visited.Contains(node)){
                continue;
            }
            visited.Add(node);
            List<int> neighbors = graph[node];
            foreach(int neighbor in neighbors) {
                queue.Enqueue(neighbor);
            }
        }
        return visited.Count == n;
    }
}

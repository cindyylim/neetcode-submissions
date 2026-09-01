public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        Dictionary<int, List<(int neighbor, int time)>> map = new Dictionary<int, List<(int neighbor, int time)>>();
        for (int i = 1; i <= n; i++) {
            map[i] = new List<(int neighbor, int time)>();
        }
        foreach(int[] edge in times) {
            int from = edge[0];
            int to = edge[1];
            int time = edge[2];
            map[from].Add((to, time));
        }
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int[] distances = new int[n + 1];
        Array.Fill(distances, int.MaxValue);
        distances[k] = 0;
        pq.Enqueue(k, 0);
        while (pq.Count > 0){
            pq.TryDequeue(out int node, out int currTime);
            if (currTime > distances[node]){
                continue;
            }
            foreach ((int neighbor, int time) in map[node]) {
                int newTime = time + currTime;
                if (newTime < distances[neighbor]) {
                    distances[neighbor] = newTime;
                    pq.Enqueue(neighbor, newTime);
                }
            } 
        }
        int result = 0;
        for (int i = 1; i <= n; i++) {
            if (distances[i] == int.MaxValue) {
                return -1;
            }
            result = Math.Max(distances[i], result);
        }
        return result;
    }
}

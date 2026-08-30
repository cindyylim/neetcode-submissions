public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int> order = new List<int>();
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i < numCourses; i++) {
            graph.Add(new List<int>());
        }
        int[] indegree = new int[numCourses];
        foreach(int[] pre in prerequisites) {
            int course = pre[0];
            int prereq = pre[1];
            graph[prereq].Add(course);
            indegree[course]++;
        }
        Queue<int> queue = new Queue<int>();
        int visited = 0;
        for (int i = 0; i < numCourses; i++) {
            if (indegree[i] == 0) {
                queue.Enqueue(i);
            }
        }
        while (queue.Count > 0) {
            int course = queue.Dequeue();
            order.Add(course);
            visited++;
            List<int> neighbors = graph[course];
            foreach(int neighbor in neighbors){
                indegree[neighbor]--;
                if (indegree[neighbor] == 0) {
                    queue.Enqueue(neighbor);
                }
            }
        }
        return numCourses == visited ? order.ToArray() : new int[0];
    }
}

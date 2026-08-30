public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i < numCourses; i++) {
            graph.Add(new List<int>());
        }
        int[] indegree = new int[numCourses];
        foreach (int[] prereq in prerequisites) {
            int course = prereq[0];
            int pre = prereq[1];
            graph[pre].Add(course);
            indegree[course]++;
        }
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (indegree[i] == 0) {
                queue.Enqueue(i);
            }
        }
        int visited = 0;
        while (queue.Count > 0) {
            int course = queue.Dequeue();
            visited ++;
            List<int> neighbors = graph[course];
            foreach (int neighbor in neighbors) {
                indegree[neighbor]--;
                if (indegree[neighbor] == 0) {
                    queue.Enqueue(neighbor);
                }
            }
        }
        return visited == numCourses;
    }
}

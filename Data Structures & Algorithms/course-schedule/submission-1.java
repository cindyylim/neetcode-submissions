class Solution {
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        Queue<Integer> queue = new LinkedList<>();
        List<List<Integer>> graph = new ArrayList<>();
        int[] indegrees = new int[numCourses];
        for (int i = 0; i < numCourses; i++) {
            graph.add(new ArrayList<>());
        }
        for(int[] prereq : prerequisites) {
            graph.get(prereq[1]).add(prereq[0]);
            indegrees[prereq[0]]++;
        }
        for (int i = 0; i < numCourses; i++) {
            if (indegrees[i] == 0) {
                queue.add(i);
            }
        }
        int completed =0 ;
        while (!queue.isEmpty()) {
            int course = queue.remove();
            completed++;
            for (int nextCourse : graph.get(course)) {
                indegrees[nextCourse]--;
                if (indegrees[nextCourse] == 0) {
                    queue.add(nextCourse);
                }
            }
        }
        return completed == numCourses;
    }
}

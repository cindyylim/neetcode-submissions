class Solution {
    class Pair {
        private double distance;
        private int index;
        public Pair(double distance, int index) {
            this.distance = distance;
            this.index = index;
        }
    }
    public int[][] kClosest(int[][] points, int k) {
        PriorityQueue<Pair> maxHeap = new PriorityQueue<Pair>((a, b) -> Double.compare(b.distance, a.distance));
        for(int i = 0; i < points.length; i++) {
            int[] point = points[i];
            int x = point[0];
            int y = point[1];
            double distance = (double)Math.sqrt((x * x) + (y * y));
            maxHeap.add(new Pair(distance, i));
            if (maxHeap.size() > k) {
                maxHeap.remove();
            }
        }
        int[][] answer = new int[k][2];
        for (int i =0 ;i < k; i++) {
            if (!maxHeap.isEmpty()) {
                answer[i] = points[maxHeap.remove().index];
            }
        }
        return answer;

    }
}

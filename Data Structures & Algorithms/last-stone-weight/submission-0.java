class Solution {
    public int lastStoneWeight(int[] stones) {
        PriorityQueue<Integer> q = new PriorityQueue<>();
        for(int s: stones) {
            q.offer(-s);
        }
        while(q.size() > 1) {
            int first = q.poll();
            int second = q.poll();
            if (second > first) {
                q.offer(first - second);
            }
         }
         q.offer(0);
         return Math.abs(q.peek());
    }
}

class KthLargest {
    private PriorityQueue<Integer> q;
    private int k;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.q = new PriorityQueue<>();
        for (int num: nums) {
            q.offer(num);
            if (q.size() > k) {
                q.poll();
            }
        }
    }
    
    public int add(int val) {
        q.offer(val);
        if(q.size() > k) {
            q.poll();
        }
        return q.peek();
    }
}

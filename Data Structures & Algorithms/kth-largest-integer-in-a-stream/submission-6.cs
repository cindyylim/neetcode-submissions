public class KthLargest {
    private readonly PriorityQueue<int, int> pq;
    private readonly int k;
    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int, int>();
        this.k = k;

        foreach (int num in nums) {
            Add(num);
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        if (pq.Count > this.k) {
            pq.Dequeue();
        }
        pq.TryPeek(out int kthLargest, out _);
        return kthLargest;
    }
}

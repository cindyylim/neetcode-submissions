class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        Map<Integer, Integer> freq = new HashMap<>();
        for (int num: nums) {
            freq.compute(num, (x, v)-> v == null? 1 : v + 1);
        }
        PriorityQueue<int[]> pq = new PriorityQueue<>((a, b) -> b[0] - a[0]);
        for (Map.Entry<Integer, Integer> entry: freq.entrySet()) {
            int key = entry.getKey();
            int v = entry.getValue();
            pq.add(new int[]{v, key});
        }
        int[] result = new int[k];
        for (int i =0; i < k; i++) {
            result[i] = pq.poll()[1];
        }
        return result;
    }
}

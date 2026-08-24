class Solution {
    public int lastStoneWeight(int[] stones) {
        PriorityQueue<Integer> maxHeap = new PriorityQueue<>(Collections.reverseOrder());
        for (int stone : stones) {
            maxHeap.add(stone);
        }
        while (maxHeap.size() > 1) {
            int heaviest = maxHeap.remove();
            int second = maxHeap.remove();
            if (heaviest == second) {
                continue;
            }
            if (second < heaviest) {
                maxHeap.add(heaviest - second);
            }
        }
        return maxHeap.size() == 0 ? 0 : maxHeap.peek();
    }
}

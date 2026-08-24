class Solution {
    public int leastInterval(char[] tasks, int n) {
        PriorityQueue<Integer> maxHeap = new PriorityQueue<>(Collections.reverseOrder());
        int time =0 ;
        int[] freq = new int[26];
        for(char c: tasks) {
            freq[c - 'A']++;
        }
        for(int count: freq) {
            if (count > 0) {
                maxHeap.add(count);
            }
        }
        while(!maxHeap.isEmpty()) {
            List<Integer> temp = new ArrayList<>();
            int cycle = n + 1;
            while (cycle > 0 && !maxHeap.isEmpty()) {
                cycle--;
                time++;
                int count = maxHeap.remove();
                if (count - 1 > 0) {
                    temp.add(count - 1);
                }
            }
            for (int count : temp) {
                maxHeap.add(count);
            }
            if (maxHeap.isEmpty()) {
                break;
            }
            time += cycle ;
        }
        return time;
    }
}

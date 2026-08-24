class Solution {
    public int leastInterval(char[] tasks, int n) {
        int[] freq = new int[26];
        for (char c : tasks){
            freq[c - 'A']++;
        }
        PriorityQueue<Integer> maxHeap = new PriorityQueue<>(Collections.reverseOrder());
    
        for (int count : freq) {
            if (count > 0) {
                maxHeap.add(count);
            }
        }
        int time = 0;
        while (!maxHeap.isEmpty()){
            List<Integer> temp = new ArrayList<>();
            int cycle = n + 1;
            while (cycle > 0 && !maxHeap.isEmpty()) {
                int count = maxHeap.remove();
                if (count - 1 > 0) {
                    temp.add(count - 1);
                }
                cycle --;
                time ++;
            }
            for(int count : temp) {
                maxHeap.add(count);
            }
            if (maxHeap.isEmpty()) {
                break;
            }
            time += cycle;
        }
        return time;
    }
}

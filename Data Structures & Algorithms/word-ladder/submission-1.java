class Solution {
    public int ladderLength(String beginWord, String endWord, List<String> wordList) {
        if (!wordList.contains(endWord)){
            return 0;
        }
        Map<String, List<String>> neighbor = new HashMap<>();
        wordList.add(beginWord);
        for(String word: wordList) {
            for (int j = 0; j < word.length(); j++) {
                String pattern = word.substring(0, j) + "*" + word.substring(j + 1);
                neighbor.computeIfAbsent(pattern, k -> new ArrayList<>()).add(word);
            }
        }
        Set<String> visit = new HashSet<>();
        Queue<String> q = new LinkedList<>();
        q.offer(beginWord);
        int res = 1;
        while (!q.isEmpty()){
            int size = q.size();
            for (int i = 0; i < size; i++) {
                String word = q.poll();
                if (word.equals(endWord)){
                    return res;
                }
                for(int j = 0; j < word.length(); j++){
                    String pattern = word.substring(0, j) + "*" + word.substring(j + 1);
                    for (String neighborWord: neighbor.getOrDefault(pattern, Collections.emptyList())){
                        if (!visit.contains(neighborWord)){
                            visit.add(neighborWord);
                            q.offer(neighborWord);
                        }
                    }
                }
                
            }
            res++;
        }
        return 0;
    }
}

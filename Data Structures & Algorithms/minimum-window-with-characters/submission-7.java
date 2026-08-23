class Solution {
    public String minWindow(String s, String t) {
        if (t.length() > s.length()) {
            return "";
        }
        int start = 0;
        Map<Character, Integer> need = new HashMap<>();
        for (char c: t.toCharArray()) {
            need.put(c, need.getOrDefault(c, 0) + 1);
        }
        int minNeeded = need.size();
        int shortest = Integer.MAX_VALUE;
        String result = "";
        for(int i =0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (need.containsKey(c)){
                need.put(c, need.get(c) - 1);
                if (need.get(c) == 0) {
                    minNeeded -= 1;
                }
                while (minNeeded == 0) {
                    int windowLength = i - start + 1;
                    if (windowLength < shortest) {
                        shortest = windowLength;
                        result = s.substring(start, i + 1);
                    }
                    char startChar = s.charAt(start);
                    if (need.containsKey(startChar)) {
                        need.put(startChar, need.get(startChar) + 1);
                        if (need.get(startChar) > 0) {
                            minNeeded++;
                        }
                    }
                    start++;
                }
            }
        }
        return result;
    }
}

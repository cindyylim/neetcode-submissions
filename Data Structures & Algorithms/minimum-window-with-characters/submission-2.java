class Solution {
    public String minWindow(String s, String t) {
        if (t.isEmpty()) return "";
        Map<Character, Integer> count = new HashMap<>();
        Map<Character, Integer> window = new HashMap<>();
        for (char c : t.toCharArray()){
            count.put(c, count.getOrDefault(c, 0) + 1);
        }
        int l = 0; 
        int[] res = {-1, -1};
        int resLength = Integer.MAX_VALUE;
        int have = 0, need = count.size();
        for (int r = 0; r < s.length(); r++){
            char c = s.charAt(r);
            window.put(c, window.getOrDefault(c, 0) + 1);
            if(count.containsKey(c) && count.get(c) == window.get(c)){
                have += 1;
            }
            while (have == need){
                if ((r - l + 1) < resLength){
                    resLength = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }
                char left = s.charAt(l);
                window.put(left, window.get(left) - 1);
                if (count.containsKey(left) && window.get(left) < count.get(left)){
                    have -= 1;
                }
                l++;
            }
        }
        return resLength == Integer.MAX_VALUE ? "" : s.substring(res[0], res[1] + 1);
    }
}

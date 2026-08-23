class Solution {

    public String encode(List<String> strs) {
        if (strs.size() == 0) {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        for (String s: strs) {
            sb.append(s.length());
            sb.append("#");
            sb.append(s);
        }
        return sb.toString();
    }

    public List<String> decode(String str) {
        if (str == "") {
            return new ArrayList<>();
        }
        int i = 0; 
        List<String> result = new ArrayList<>();
        while (i < str.length()) {
            int j = i;
            while (str.charAt(j) != '#') {
                j += 1;
            }
            int length = Integer.parseInt(str.substring(i, j));
            j += 1;
            String s = str.substring(j, j + length);
            result.add(s);
            i = j + length;
        }
        return result;
    }
}

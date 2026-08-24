class Solution {
    public List<String> letterCombinations(String digits) {
        List<String> result = new ArrayList<>();
        if (digits.length() == 0) {
            return result;
        }
        String[] map = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
        backtrack(digits, 0, new StringBuilder(), map, result);
        return result;
    }
    private void backtrack(String digits, int index, StringBuilder sb, String[] map, List<String> result) {
        if (digits.length() == index) {
            result.add(sb.toString());
            return;
        }
        String letters = map[digits.charAt(index) - '0'];
        for(char c: letters.toCharArray()) {
            sb.append(c);
            backtrack(digits, index + 1, sb, map, result);
            sb.deleteCharAt(sb.length() - 1);
        }
    }
}

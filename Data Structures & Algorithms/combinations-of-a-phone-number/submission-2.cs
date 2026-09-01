public class Solution {
    public List<string> LetterCombinations(string digits) {
        List<string> result = new List<string>();
        if (digits.Length == 0){
            return result;
        }
        string[] map = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
        Backtrack(digits, 0, new StringBuilder(), map, result);
        return result;
    }
    private void Backtrack(string digits, int index, StringBuilder sb, string[] map, List<string> result) {
        if (digits.Length == index) {
            result.Add(sb.ToString());
            return;
        }
        string letters = map[digits[index] - '0'];
        foreach (char c in letters) {
            sb.Append(c);
            Backtrack(digits, index + 1, sb, map, result);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}

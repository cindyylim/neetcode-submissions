public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        Backtrack(0, 0, n, new StringBuilder(), result);
        return result;
    }
    private void Backtrack(int open, int close, int n, StringBuilder sb, List<string> result) {
        if (open == n && close == n) {
            result.Add(sb.ToString());
            return;
        }
        if (open < n) {
            sb.Append("(");
            Backtrack(open + 1, close, n, sb, result);
            sb.Remove(sb.Length - 1, 1);
        }
        if (close < open) {
            sb.Append(")");
            Backtrack(open, close + 1, n, sb, result);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}

public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> result = new List<List<string>>();
        Backtrack(0, s, new List<string>(), result);
        return result;
    }
    private void Backtrack(int start, string s, List<string> curr, List<List<string>> result) {
        if (start == s.Length) {
            result.Add(new List<string>(curr));
            return;
        }
        for (int i = start; i < s.Length; i++) {
            if (isPalindrome(s, start, i)) {
                curr.Add(s.Substring(start, i + 1 - start));
                Backtrack(i + 1, s, curr, result);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
    private bool isPalindrome(string s, int left, int right) {
        while (left < right) {
            if (s[left] != s[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<String, List<string>>();
        foreach (string s in strs) {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sorted = new string(charArray);
            if (!map.ContainsKey(sorted)) {
                map[sorted] = new List<string>();
            }
            map[sorted].Add(s);
        }
        return map.Values.ToList();
    }
}

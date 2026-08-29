public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach (string s in strs) {
            sb.Append(s.Length);
            sb.Append("#");
            sb.Append(s);
        }
        return sb.ToString();
    }


    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            j++;
            result.Add(s.Substring(j, length));
            i = j + length;
        }
        return result;
    }
}

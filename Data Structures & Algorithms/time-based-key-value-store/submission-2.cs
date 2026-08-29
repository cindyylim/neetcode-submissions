public class TimeMap {
    private readonly Dictionary<string, List<(int Timestamp, string Value)>> map;
    public TimeMap() {
        map = new Dictionary<string, List<(int Timestamp, string Value)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!map.ContainsKey(key)){
            map[key] = new List<(int Timestamp, string Value)>();
        }
        map[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!map.ContainsKey(key)){
            return "";
        }  
        var values = map[key];
        int left =0;
        int right = values.Count - 1;
        string result = "";
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (values[mid].Timestamp <= timestamp) {
                result = values[mid].Value;
                left = mid + 1;
            }else {
                right = mid - 1;
            }
        }
        return result;
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach(int num in nums) {
            if (!map.ContainsKey(num)){
                map[num] = 0;
            }
            map[num] = map[num] + 1;
        }
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var entry in map) {
            int freq = entry.Value;
            if (buckets[freq] == null) {
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(entry.Key);
        }
        List<int> result = new List<int>();
        for(int i = buckets.Length - 1; i >= 0 && result.Count < k; i--) {  
            if (buckets[i] == null) {
                continue;
            }
            foreach(int num in buckets[i]) {
                result.Add(num);
                if (result.Count == k) {
                    break;
                }
            }
        }
        return result.ToArray();
    }
}

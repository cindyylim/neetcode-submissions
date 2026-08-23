class Pair {
    private int timestamp;
    private String value;
    public Pair(int timestamp, String value) {
        this.timestamp = timestamp;
        this.value = value;
    }
}
class TimeMap {
    Map<String, List<Pair>> map;
    public TimeMap() {
        map = new HashMap<>();
    }
    
    public void set(String key, String value, int timestamp) {
        map.computeIfAbsent(key, k -> new ArrayList<>()).add(new Pair(timestamp, value));
    }
    
    public String get(String key, int timestamp) {
        List<Pair> lists = map.computeIfAbsent(key, k -> new ArrayList<>());
        int left = 0, right = lists.size() - 1;
        String result = "";
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (lists.get(mid).timestamp <= timestamp) {
                result = lists.get(mid).value;
                left = mid + 1;
            }else {
                right = mid - 1;
            }
        }
        return result;
    }
}

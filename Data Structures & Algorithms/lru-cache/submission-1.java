class LRUCache {
    private class ListNode {
        private int key;
        private int val;
        private ListNode next;
        private ListNode prev;
        public ListNode(int key, int val) {
            this.key = key;
            this.val = val;
        }
    }
    private final int capacity;
    private Map<Integer, ListNode> map;
    private final ListNode head;
    private final ListNode tail;
    public LRUCache(int capacity) {
        this.map = new HashMap<>();
        this.capacity = capacity;
        head = new ListNode(0, 0);
        tail = new ListNode(0, 0);
        tail.prev = head;
        head.next = tail;
    }
    
    public int get(int key) {
        if (!map.containsKey(key)) {
            return -1;
        }
        ListNode node = map.get(key);
        remove(node);
        putAtFront(node);
        return node.val;
    }

    private void remove(ListNode node) {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
    private void putAtFront(ListNode node) {
        node.next = head.next;
        node.prev = head;
        head.next.prev = node;
        head.next = node;
    }
    
    public void put(int key, int value) {
        if (!map.containsKey(key)) {
            ListNode node = new ListNode(key, value);
            map.put(key, node);
            putAtFront(node);
        } else {
            ListNode node = map.get(key);
            node.val = value;
            remove(node);
            putAtFront(node);
            return;
        }
        if (map.size() > this.capacity) {
            ListNode lru = tail.prev;
            remove(lru);
            map.remove(lru.key);
        }

    }
}

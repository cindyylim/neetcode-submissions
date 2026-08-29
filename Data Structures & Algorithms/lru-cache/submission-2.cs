public class LRUCache {
    private class Node {
        public int key;
        public int value;
        public Node prev;
        public Node next;
        public Node(int key =0, int value = 0) {
            this.key = key;
            this.value = value;
        }
    }
    private int capacity;
    private Dictionary<int, Node> map;
    private readonly Node head;
    private readonly Node tail; 
    public LRUCache(int capacity) {
        this.capacity = capacity;
        this.map = new Dictionary<int, Node>();
         head = new Node();
         tail = new Node();
         head.next = tail;
         tail.prev = head;
    }
    
    public int Get(int key) {
        if (!map.ContainsKey(key)){
            return -1;
        }
        Node node = map[key];
        remove(node);
        putAtFront(node);
        return node.value;
    }
    
    public void Put(int key, int value) {
        if (map.ContainsKey(key)){
            remove(map[key]);
            map.Remove(key);
        }
        Node newNode = new Node(key, value);
        putAtFront(newNode);
        map[key] = newNode;
        if (map.Count > this.capacity) {
            Node lru = tail.prev;
            remove(tail.prev);
            map.Remove(lru.key);
        }
    }
    private void remove(Node node) {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
    private void putAtFront(Node node) {
        Node next = head.next;
        head.next = node;
        node.prev = head;
        next.prev = node;
        node.next = next;
    }
}
    

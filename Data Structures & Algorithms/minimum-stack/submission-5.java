class MinStack {
    Deque<Integer> stack;
    Deque<Integer> minStack;
    public MinStack() {
        this.stack = new ArrayDeque<>();
        this.minStack = new ArrayDeque<>();
    }
    
    public void push(int val) {
        this.stack.push(val);
        int minVal = this.minStack.isEmpty() ? val : Math.min(val, this.minStack.peek());
        this.minStack.push(minVal);
    }
    
    public void pop() {
        this.minStack.pop();
        this.stack.pop();
    }
    
    public int top() {
        return this.stack.peek();
    }
    
    public int getMin() {
        return this.minStack.peek();
    }
}

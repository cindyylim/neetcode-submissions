class Solution {
    public int evalRPN(String[] tokens) {
        Deque<Integer> stack = new ArrayDeque<>();
        String operators = "+*/-";
        for (String s : tokens) {
            if (operators.contains(s)) {
                int right = stack.pop();
                int left = stack.pop();
                if (s.equals("+")) {
                    stack.push(left + right);
                }else if (s.equals("-")) {
                    stack.push(left - right);
                }else if (s.equals("/")) {
                    stack.push(left / right);
                }else{
                    stack.push(left * right);
                }
            }else{
                stack.push(Integer.parseInt(s));
            }   
        }
        return stack.pop();
    }
}

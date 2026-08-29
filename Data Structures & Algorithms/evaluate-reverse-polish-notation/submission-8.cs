public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        string operations = "+-/*";
        foreach(string s in tokens) {
            if (operations.Contains(s)) {
                int right = stack.Pop();
                int left = stack.Pop();
                if (s.Equals("+")) {
                    stack.Push(left + right);
                }else if (s.Equals("-")) {
                    stack.Push(left - right);
                }else if (s.Equals("*")) {
                    stack.Push(left * right);
                }else {
                    stack.Push(left / right);
                }
            } else {
                stack.Push(int.Parse(s));
            }
        }
        return stack.Pop();
    }
}

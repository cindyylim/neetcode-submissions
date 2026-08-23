class Solution {
    public boolean isValid(String s) {
        Map<Character, Character> closeToOpen = Map.of(')', '(', '}', '{', ']', '[');
        Deque<Character> stack = new ArrayDeque<>();
        for(char c: s.toCharArray()) {
            if (closeToOpen.containsKey(c)) {
                if (stack.size() == 0 || stack.pop() != closeToOpen.get(c)){
                    return false;
                }
            }else{
                stack.push(c);
            }
        }
        return stack.size() == 0;
    }
}

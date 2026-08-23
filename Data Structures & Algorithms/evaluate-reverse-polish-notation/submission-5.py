class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []
        for token in tokens:
            if token not in "+*/-":
                stack.append(int(token))
            else:
                right = stack.pop()
                left = stack.pop()

                if token == "+":
                    stack.append(right + left)
                elif token == "*":
                    stack.append(right * left)
                elif token == "/":
                    stack.append(int(left / right))
                else:
                    stack.append(left - right)
        return stack[-1]
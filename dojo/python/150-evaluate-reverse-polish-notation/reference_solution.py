class ReferenceSolution:
    # O(n) time. Push operands; each operator consumes the last two.
    def eval_rpn(self, tokens: list[str]) -> int:
        stack: list[int] = []
        for token in tokens:
            if token in {"+", "-", "*", "/"}:
                right = stack.pop()
                left = stack.pop()
                if token == "+":
                    stack.append(left + right)
                elif token == "-":
                    stack.append(left - right)
                elif token == "*":
                    stack.append(left * right)
                else:
                    stack.append(int(left / right))
            else:
                stack.append(int(token))
        return stack[0]

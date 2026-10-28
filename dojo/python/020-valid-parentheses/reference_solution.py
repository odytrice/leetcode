class ReferenceSolution:
    # O(n) time. Every closer must match the most recent opener.
    def is_valid(self, s: str) -> bool:
        pairs = {")": "(", "]": "[", "}": "{"}
        stack: list[str] = []
        for char in s:
            if char in pairs:
                if not stack or stack.pop() != pairs[char]:
                    return False
            else:
                stack.append(char)
        return not stack

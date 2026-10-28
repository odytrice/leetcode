from solution import MinStack


class ReferenceSolution(MinStack):
    # O(1) per operation. Each entry remembers the minimum at or below it.
    def __init__(self) -> None:
        self.stack: list[tuple[int, int]] = []

    def push(self, val: int) -> None:
        current_min = val if not self.stack else min(val, self.stack[-1][1])
        self.stack.append((val, current_min))

    def pop(self) -> None:
        self.stack.pop()

    def top(self) -> int:
        return self.stack[-1][0]

    def get_min(self) -> int:
        return self.stack[-1][1]

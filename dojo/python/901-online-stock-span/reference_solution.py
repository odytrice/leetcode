from solution import StockSpanner


class ReferenceSolution(StockSpanner):
    # Amortized O(1) per call. Drop prices no higher than today's, summing their spans.
    def __init__(self) -> None:
        self.stack: list[tuple[int, int]] = []

    def next(self, price: int) -> int:
        span = 1
        while self.stack and self.stack[-1][0] <= price:
            span += self.stack.pop()[1]
        self.stack.append((price, span))
        return span

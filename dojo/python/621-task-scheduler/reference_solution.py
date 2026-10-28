from collections import Counter


class ReferenceSolution:
    # O(n) time. The most frequent task sets the frame; ties add one slot each.
    def least_interval(self, tasks: list[str], n: int) -> int:
        counts = Counter(tasks)
        most = max(counts.values())
        tied = sum(1 for count in counts.values() if count == most)
        return max(len(tasks), (most - 1) * (n + 1) + tied)

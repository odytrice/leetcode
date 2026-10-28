class ReferenceSolution:
    # O(n log n) time. Sorting by squared distance keeps the arithmetic exact.
    def k_closest(self, points: list[list[int]], k: int) -> list[list[int]]:
        return sorted(points, key=lambda point: point[0] * point[0] + point[1] * point[1])[:k]

class ReferenceSolution:
    # O(n log n) time. Shoot at the earliest finishing balloon that is still uncovered.
    def find_min_arrow_shots(self, points: list[list[int]]) -> int:
        arrows = 0
        end = float("-inf")
        for start, finish in sorted(points, key=lambda point: point[1]):
            if start > end:
                arrows += 1
                end = finish
        return arrows

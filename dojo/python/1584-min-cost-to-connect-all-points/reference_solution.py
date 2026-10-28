class ReferenceSolution:
    # O(n^2) time. Dense Prim: pick the cheapest link to the growing tree.
    def min_cost_connect_points(self, points: list[list[int]]) -> int:
        size = len(points)
        used = [False] * size
        best = [float("inf")] * size
        best[0] = 0
        total = 0
        for _ in range(size):
            chosen = -1
            for node in range(size):
                if not used[node] and (chosen == -1 or best[node] < best[chosen]):
                    chosen = node
            used[chosen] = True
            total += best[chosen]
            for node in range(size):
                if not used[node]:
                    cost = abs(points[chosen][0] - points[node][0]) + abs(points[chosen][1] - points[node][1])
                    best[node] = min(best[node], cost)
        return int(total)

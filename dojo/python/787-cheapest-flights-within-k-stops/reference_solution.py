class ReferenceSolution:
    # O(k * flights) time. Bellman-Ford rounds, each using at most one new edge.
    def find_cheapest_price(
        self, n: int, flights: list[list[int]], src: int, dst: int, k: int
    ) -> int:
        unreachable = float("inf")
        distance = [unreachable] * n
        distance[src] = 0
        for _ in range(k + 1):
            following = list(distance)
            for source, target, price in flights:
                if distance[source] != unreachable:
                    following[target] = min(following[target], distance[source] + price)
            distance = following
        return -1 if distance[dst] == unreachable else int(distance[dst])

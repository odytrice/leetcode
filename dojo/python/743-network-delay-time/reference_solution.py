import heapq


class ReferenceSolution:
    # O(edges log nodes) time. Dijkstra from the source; the answer is the farthest arrival.
    def network_delay_time(self, times: list[list[int]], n: int, k: int) -> int:
        graph: list[list[tuple[int, int]]] = [[] for _ in range(n + 1)]
        for source, target, weight in times:
            graph[source].append((target, weight))

        distance = [float("inf")] * (n + 1)
        distance[k] = 0
        heap = [(0, k)]
        while heap:
            cost, node = heapq.heappop(heap)
            if cost != distance[node]:
                continue
            for target, weight in graph[node]:
                next_cost = cost + weight
                if next_cost < distance[target]:
                    distance[target] = next_cost
                    heapq.heappush(heap, (next_cost, target))

        answer = max(distance[1:])
        return -1 if answer == float("inf") else int(answer)

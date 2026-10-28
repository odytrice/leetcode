class ReferenceSolution:
    # O(n) time. Peel leaves layer by layer; the last one or two nodes are the centres.
    def find_min_height_trees(self, n: int, edges: list[list[int]]) -> list[int]:
        if n == 1:
            return [0]
        graph: list[list[int]] = [[] for _ in range(n)]
        degree = [0] * n
        for first, second in edges:
            graph[first].append(second)
            graph[second].append(first)
            degree[first] += 1
            degree[second] += 1

        leaves = [node for node in range(n) if degree[node] == 1]
        remaining = n
        while remaining > 2:
            remaining -= len(leaves)
            next_leaves: list[int] = []
            for leaf in leaves:
                for neighbor in graph[leaf]:
                    degree[neighbor] -= 1
                    if degree[neighbor] == 1:
                        next_leaves.append(neighbor)
            leaves = next_leaves
        return sorted(leaves)

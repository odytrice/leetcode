class ReferenceSolution:
    # O(n) time. Union each edge; the first edge inside one component is the extra one.
    def find_redundant_connection(self, edges: list[list[int]]) -> list[int]:
        parent = list(range(len(edges) + 1))

        def find(node: int) -> int:
            while parent[node] != node:
                parent[node] = parent[parent[node]]
                node = parent[node]
            return node

        for first, second in edges:
            root_first, root_second = find(first), find(second)
            if root_first == root_second:
                return [first, second]
            parent[root_first] = root_second
        raise ValueError("No redundant edge")

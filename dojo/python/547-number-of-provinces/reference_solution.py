class ReferenceSolution:
    # O(n^2) time. Union every connected pair and count the remaining components.
    def find_circle_num(self, is_connected: list[list[int]]) -> int:
        size = len(is_connected)
        components = size
        parent = list(range(size))

        def find(node: int) -> int:
            while parent[node] != node:
                parent[node] = parent[parent[node]]
                node = parent[node]
            return node

        for first in range(size):
            for second in range(first + 1, size):
                if is_connected[first][second] != 1:
                    continue
                root_first, root_second = find(first), find(second)
                if root_first != root_second:
                    parent[root_first] = root_second
                    components -= 1
        return components

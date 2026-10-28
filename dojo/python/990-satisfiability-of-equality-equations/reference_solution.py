class ReferenceSolution:
    # O(n) time. Union equal letters, then reject any inequality inside one set.
    def equations_possible(self, equations: list[str]) -> bool:
        parent = list(range(26))

        def find(node: int) -> int:
            while parent[node] != node:
                parent[node] = parent[parent[node]]
                node = parent[node]
            return node

        for equation in equations:
            if equation[1] == "=":
                parent[find(ord(equation[0]) - ord("a"))] = find(ord(equation[3]) - ord("a"))
        for equation in equations:
            if equation[1] == "!" and find(ord(equation[0]) - ord("a")) == find(ord(equation[3]) - ord("a")):
                return False
        return True

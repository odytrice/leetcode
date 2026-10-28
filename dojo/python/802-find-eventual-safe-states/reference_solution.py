class ReferenceSolution:
    # O(nodes + edges) time. Reverse Kahn's algorithm from terminal nodes.
    def eventual_safe_nodes(self, graph: list[list[int]]) -> list[int]:
        count = len(graph)
        reverse: list[list[int]] = [[] for _ in range(count)]
        degree = [0] * count
        for node, outgoing in enumerate(graph):
            degree[node] = len(outgoing)
            for target in outgoing:
                reverse[target].append(node)

        queue = [node for node in range(count) if degree[node] == 0]
        while queue:
            node = queue.pop()
            for source in reverse[node]:
                degree[source] -= 1
                if degree[source] == 0:
                    queue.append(source)
        return [node for node in range(count) if degree[node] == 0]

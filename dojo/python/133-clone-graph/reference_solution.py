from solution import GraphNode


class ReferenceSolution:
    # O(nodes + edges) time. Copy each node once, then relink its neighbours.
    def clone_graph(self, node: GraphNode | None) -> GraphNode | None:
        if node is None:
            return None
        copies = {id(node): GraphNode(node.val)}
        queue = [node]
        while queue:
            original = queue.pop()
            for neighbor in original.neighbors:
                if id(neighbor) not in copies:
                    copies[id(neighbor)] = GraphNode(neighbor.val)
                    queue.append(neighbor)
                copies[id(original)].neighbors.append(copies[id(neighbor)])
        return copies[id(node)]

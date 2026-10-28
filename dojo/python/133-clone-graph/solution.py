from __future__ import annotations


class GraphNode:
    def __init__(self, val: int = 0, neighbors: list[GraphNode] | None = None) -> None:
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []


class Solution:
    def clone_graph(self, node: GraphNode | None) -> GraphNode | None:
        raise NotImplementedError

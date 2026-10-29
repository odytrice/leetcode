import { GraphNode } from "./solution.ts";

// O(nodes + edges) time. Copies each node once, then relinks its neighbours.
export function cloneGraph(node: GraphNode | null): GraphNode | null {
  if (node === null) {
    return null;
  }
  const copies = new Map<GraphNode, GraphNode>([[node, new GraphNode(node.val)]]);
  const queue: GraphNode[] = [node];
  while (queue.length > 0) {
    const original = queue.pop() as GraphNode;
    for (const neighbor of original.neighbors) {
      if (!copies.has(neighbor)) {
        copies.set(neighbor, new GraphNode(neighbor.val));
        queue.push(neighbor);
      }
      (copies.get(original) as GraphNode).neighbors.push(copies.get(neighbor) as GraphNode);
    }
  }
  return copies.get(node) as GraphNode;
}

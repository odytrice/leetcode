// O(n) time. Unions each edge; the first edge inside one component is the extra one.
export function findRedundantConnection(edges: number[][]): number[] {
  // parent[node] links each node towards its set's root; nodes are numbered from 1.
  const parent = Array.from({ length: edges.length + 1 }, (_, index) => index);

  const find = (node: number): number => {
    while (parent[node] !== node) {
      // Path halving: point nodes at their grandparents to keep trees shallow.
      parent[node] = parent[parent[node]];
      node = parent[node];
    }
    return node;
  };

  for (const [first, second] of edges) {
    const rootFirst = find(first);
    const rootSecond = find(second);
    // Both ends are already connected, so this edge closes a cycle.
    if (rootFirst === rootSecond) {
      return [first, second];
    }
    parent[rootFirst] = rootSecond;
  }
  throw new Error("No redundant edge");
}

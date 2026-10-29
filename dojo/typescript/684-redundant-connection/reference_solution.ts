// O(n) time. Unions each edge; the first edge inside one component is the extra one.
export function findRedundantConnection(edges: number[][]): number[] {
  const parent = Array.from({ length: edges.length + 1 }, (_, index) => index);

  const find = (node: number): number => {
    while (parent[node] !== node) {
      parent[node] = parent[parent[node]];
      node = parent[node];
    }
    return node;
  };

  for (const [first, second] of edges) {
    const rootFirst = find(first);
    const rootSecond = find(second);
    if (rootFirst === rootSecond) {
      return [first, second];
    }
    parent[rootFirst] = rootSecond;
  }
  throw new Error("No redundant edge");
}

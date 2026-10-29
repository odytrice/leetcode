// O(n^2) time. Unions every connected pair and counts the remaining components.
export function findCircleNum(isConnected: number[][]): number {
  const count = isConnected.length;
  // parent[node] links each node towards its set's root; every node starts as its own set.
  const parent = Array.from({ length: count }, (_, index) => index);
  let components = count;

  const find = (node: number): number => {
    // Path halving: point nodes at their grandparents to keep trees shallow.
    while (parent[node] !== node) {
      parent[node] = parent[parent[node]];
      node = parent[node];
    }
    return node;
  };

  for (let first = 0; first < count; first += 1) {
    for (let second = first + 1; second < count; second += 1) {
      // The matrix is symmetric, so checking pairs above the diagonal is enough.
      if (isConnected[first][second] !== 1) {
        continue;
      }
      const rootFirst = find(first);
      const rootSecond = find(second);
      // Joining two different sets merges two provinces into one.
      if (rootFirst !== rootSecond) {
        parent[rootFirst] = rootSecond;
        components -= 1;
      }
    }
  }
  return components;
}

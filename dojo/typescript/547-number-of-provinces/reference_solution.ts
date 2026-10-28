// O(n^2) time. Unions every connected pair and counts the remaining components.
export function findCircleNum(isConnected: number[][]): number {
  const count = isConnected.length;
  const parent = Array.from({ length: count }, (_, index) => index);
  let components = count;

  const find = (node: number): number => {
    while (parent[node] !== node) {
      parent[node] = parent[parent[node]];
      node = parent[node];
    }
    return node;
  };

  for (let first = 0; first < count; first++) {
    for (let second = first + 1; second < count; second++) {
      if (isConnected[first][second] !== 1) continue;
      const rootFirst = find(first);
      const rootSecond = find(second);
      if (rootFirst !== rootSecond) {
        parent[rootFirst] = rootSecond;
        components--;
      }
    }
  }
  return components;
}

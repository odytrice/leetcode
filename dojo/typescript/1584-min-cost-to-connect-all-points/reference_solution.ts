// O(n^2) time. Dense Prim: picks the cheapest link to the growing tree.
export function minCostConnectPoints(points: number[][]): number {
  const size = points.length;
  // used marks points already in the tree.
  const used = new Array<boolean>(size).fill(false);
  // best[node] is the cheapest edge from node to any point already in the tree.
  const best = new Array<number>(size).fill(Number.POSITIVE_INFINITY);
  best[0] = 0;
  let total = 0;
  for (let step = 0; step < size; step += 1) {
    // Pick the unused point that is cheapest to connect.
    let chosen = -1;
    for (let node = 0; node < size; node += 1) {
      if (!used[node] && (chosen === -1 || best[node] < best[chosen])) {
        chosen = node;
      }
    }
    used[chosen] = true;
    total += best[chosen];
    // The new tree point may offer cheaper links to the points still outside.
    for (let node = 0; node < size; node += 1) {
      if (!used[node]) {
        const cost =
          Math.abs(points[chosen][0] - points[node][0]) + Math.abs(points[chosen][1] - points[node][1]);
        best[node] = Math.min(best[node], cost);
      }
    }
  }
  return total;
}

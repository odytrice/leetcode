// O(n^2) time. Dense Prim: picks the cheapest link to the growing tree.
export function minCostConnectPoints(points: number[][]): number {
  const size = points.length;
  const used = new Array<boolean>(size).fill(false);
  const best = new Array<number>(size).fill(Number.POSITIVE_INFINITY);
  best[0] = 0;
  let total = 0;
  for (let step = 0; step < size; step++) {
    let chosen = -1;
    for (let node = 0; node < size; node++) {
      if (!used[node] && (chosen === -1 || best[node] < best[chosen])) chosen = node;
    }
    used[chosen] = true;
    total += best[chosen];
    for (let node = 0; node < size; node++) {
      if (!used[node]) {
        const cost =
          Math.abs(points[chosen][0] - points[node][0]) + Math.abs(points[chosen][1] - points[node][1]);
        best[node] = Math.min(best[node], cost);
      }
    }
  }
  return total;
}

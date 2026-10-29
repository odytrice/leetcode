// O(k * flights) time. Bellman-Ford rounds, each using at most one new edge.
export function findCheapestPrice(
  n: number,
  flights: number[][],
  src: number,
  dst: number,
  k: number,
): number {
  const unreachable = Number.POSITIVE_INFINITY;
  let distance = new Array<number>(n).fill(unreachable);
  distance[src] = 0;
  for (let round = 0; round <= k; round += 1) {
    const following = [...distance];
    for (const [source, target, price] of flights) {
      if (distance[source] !== unreachable) {
        following[target] = Math.min(following[target], distance[source] + price);
      }
    }
    distance = following;
  }
  return distance[dst] === unreachable ? -1 : distance[dst];
}

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
  // distance[city] is the cheapest price found using at most round + 1 flights.
  distance[src] = 0;
  // k stops means at most k + 1 flights, so run k + 1 rounds.
  for (let round = 0; round <= k; round += 1) {
    // Read from last round's distances so each round adds at most one flight.
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

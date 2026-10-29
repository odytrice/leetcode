// O(edges log nodes) time. Dijkstra from the source; the answer is the farthest arrival.
export function networkDelayTime(times: number[][], n: number, k: number): number {
  // graph[node] lists (target, travel time) pairs; nodes are numbered from 1.
  const graph: [number, number][][] = Array.from({ length: n + 1 }, () => []);
  for (const [source, target, weight] of times) {
    graph[source].push([target, weight]);
  }

  const distance = new Array<number>(n + 1).fill(Number.POSITIVE_INFINITY);
  distance[k] = 0;
  // Each queue entry is (distance, node).
  const queue: [number, number][] = [[0, k]];
  while (queue.length > 0) {
    // Sort descending so pop() returns the closest node.
    queue.sort((a, b) => b[0] - a[0]);
    const [cost, node] = queue.pop() as [number, number];
    // Skip stale entries that were improved after they were queued.
    if (cost !== distance[node]) {
      continue;
    }
    for (const [target, weight] of graph[node]) {
      const nextCost = cost + weight;
      if (nextCost < distance[target]) {
        distance[target] = nextCost;
        queue.push([nextCost, target]);
      }
    }
  }

  // Every node hears the signal when the farthest one does; infinity means some node is unreachable.
  const answer = Math.max(...distance.slice(1));
  return answer === Number.POSITIVE_INFINITY ? -1 : answer;
}

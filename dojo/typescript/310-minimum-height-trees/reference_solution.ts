// O(n) time. Peels leaves layer by layer; the last one or two nodes are the centres.
export function findMinHeightTrees(n: number, edges: number[][]): number[] {
  if (n === 1) return [0];
  const graph: number[][] = Array.from({ length: n }, () => []);
  const degree = new Array<number>(n).fill(0);
  for (const [first, second] of edges) {
    graph[first].push(second);
    graph[second].push(first);
    degree[first]++;
    degree[second]++;
  }

  let leaves: number[] = [];
  for (let node = 0; node < n; node++) if (degree[node] === 1) leaves.push(node);
  let remaining = n;
  while (remaining > 2) {
    remaining -= leaves.length;
    const nextLeaves: number[] = [];
    for (const leaf of leaves) {
      for (const neighbor of graph[leaf]) {
        if (--degree[neighbor] === 1) nextLeaves.push(neighbor);
      }
    }
    leaves = nextLeaves;
  }
  return leaves.sort((a, b) => a - b);
}

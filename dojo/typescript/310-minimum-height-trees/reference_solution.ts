// O(n) time. Peels leaves layer by layer; the last one or two nodes are the centres.
export function findMinHeightTrees(n: number, edges: number[][]): number[] {
  // A single node is its own centre and has no edges to peel.
  if (n === 1) {
    return [0];
  }
  const graph: number[][] = Array.from({ length: n }, () => []);
  const degree = new Array<number>(n).fill(0);
  for (const [first, second] of edges) {
    graph[first].push(second);
    graph[second].push(first);
    degree[first] += 1;
    degree[second] += 1;
  }

  // Start with the outermost layer: every node with exactly one neighbour.
  let leaves: number[] = [];
  for (let node = 0; node < n; node += 1) {
    if (degree[node] === 1) {
      leaves.push(node);
    }
  }
  let remaining = n;
  // A tree has at most two centres, so stop once two or fewer nodes remain.
  while (remaining > 2) {
    remaining -= leaves.length;
    const nextLeaves: number[] = [];
    for (const leaf of leaves) {
      for (const neighbor of graph[leaf]) {
        degree[neighbor] -= 1;
        // A neighbour left with one edge becomes a leaf of the next layer.
        if (degree[neighbor] === 1) {
          nextLeaves.push(neighbor);
        }
      }
    }
    leaves = nextLeaves;
  }
  return leaves.sort((a, b) => a - b);
}

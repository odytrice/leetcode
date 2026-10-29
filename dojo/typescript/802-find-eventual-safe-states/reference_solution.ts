// O(nodes + edges) time. Reverse Kahn's algorithm from terminal nodes.
export function eventualSafeNodes(graph: number[][]): number[] {
  const count = graph.length;
  // reverse[t] lists the nodes with an edge into t; degree[node] counts outgoing edges not yet proven safe.
  const reverse: number[][] = Array.from({ length: count }, () => []);
  const degree = new Array<number>(count).fill(0);
  for (let node = 0; node < count; node += 1) {
    degree[node] = graph[node].length;
    for (const target of graph[node]) {
      reverse[target].push(node);
    }
  }

  // Terminal nodes have no outgoing edges, so they are safe.
  const queue: number[] = [];
  for (let node = 0; node < count; node += 1) {
    if (degree[node] === 0) {
      queue.push(node);
    }
  }
  while (queue.length > 0) {
    const node = queue.pop() as number;
    for (const source of reverse[node]) {
      // One more outgoing edge of source leads to a safe node.
      degree[source] -= 1;
      if (degree[source] === 0) {
        queue.push(source);
      }
    }
  }

  const result: number[] = [];
  // Nodes whose every edge leads to safety are safe; the rest can reach a cycle.
  for (let node = 0; node < count; node += 1) {
    if (degree[node] === 0) {
      result.push(node);
    }
  }
  return result;
}

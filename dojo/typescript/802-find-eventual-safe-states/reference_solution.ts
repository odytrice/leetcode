// O(nodes + edges) time. Reverse Kahn's algorithm from terminal nodes.
export function eventualSafeNodes(graph: number[][]): number[] {
  const count = graph.length;
  const reverse: number[][] = Array.from({ length: count }, () => []);
  const degree = new Array<number>(count).fill(0);
  for (let node = 0; node < count; node += 1) {
    degree[node] = graph[node].length;
    for (const target of graph[node]) {
      reverse[target].push(node);
    }
  }

  const queue: number[] = [];
  for (let node = 0; node < count; node += 1) {
    if (degree[node] === 0) {
      queue.push(node);
    }
  }
  while (queue.length > 0) {
    const node = queue.pop() as number;
    for (const source of reverse[node]) {
      degree[source] -= 1;
      if (degree[source] === 0) {
        queue.push(source);
      }
    }
  }

  const result: number[] = [];
  for (let node = 0; node < count; node += 1) {
    if (degree[node] === 0) {
      result.push(node);
    }
  }
  return result;
}

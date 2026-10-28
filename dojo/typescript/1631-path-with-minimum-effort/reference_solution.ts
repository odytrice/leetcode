// O(rows * columns log cells) time. Dijkstra on the maximum step along the path.
export function minimumEffortPath(heights: number[][]): number {
  const rows = heights.length;
  const columns = heights[0].length;
  const effort = Array.from({ length: rows }, () => new Array<number>(columns).fill(Number.POSITIVE_INFINITY));
  effort[0][0] = 0;
  const queue: [number, number, number][] = [[0, 0, 0]];
  while (queue.length > 0) {
    queue.sort((a, b) => a[0] - b[0]);
    const [cost, row, column] = queue.shift() as [number, number, number];
    if (cost !== effort[row][column]) continue;
    if (row === rows - 1 && column === columns - 1) return cost;
    for (const [nextRow, nextColumn] of [
      [row - 1, column],
      [row + 1, column],
      [row, column - 1],
      [row, column + 1],
    ]) {
      if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns) continue;
      const step = Math.max(cost, Math.abs(heights[nextRow][nextColumn] - heights[row][column]));
      if (step < effort[nextRow][nextColumn]) {
        effort[nextRow][nextColumn] = step;
        queue.push([step, nextRow, nextColumn]);
      }
    }
  }
  return 0;
}

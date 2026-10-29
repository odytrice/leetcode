// O(n^2) time. BFS over eight neighbours finds the shortest clear path.
export function shortestPathBinaryMatrix(grid: number[][]): number {
  const size = grid.length;
  // A blocked start or end means no path exists.
  if (grid[0][0] !== 0 || grid[size - 1][size - 1] !== 0) {
    return -1;
  }
  // Each queue entry is (row, column, path length so far); the start counts as length 1.
  const queue: [number, number, number][] = [[0, 0, 1]];
  // Mark a cell when it is queued so it is never queued twice.
  grid[0][0] = 1;
  // BFS reaches cells in order of path length, so the first time we see the end is the shortest.
  for (let head = 0; head < queue.length; head += 1) {
    const [row, column, length] = queue[head];
    if (row === size - 1 && column === size - 1) {
      return length;
    }
    // Try all eight neighbours; the cell itself is already marked so it is skipped.
    for (const nextRow of [row - 1, row, row + 1]) {
      for (const nextColumn of [column - 1, column, column + 1]) {
        if (nextRow >= 0 && nextColumn >= 0 && nextRow < size && nextColumn < size && grid[nextRow][nextColumn] === 0) {
          grid[nextRow][nextColumn] = 1;
          queue.push([nextRow, nextColumn, length + 1]);
        }
      }
    }
  }
  return -1;
}

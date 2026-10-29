// O(n^2) time. BFS over eight neighbours finds the shortest clear path.
export function shortestPathBinaryMatrix(grid: number[][]): number {
  const size = grid.length;
  if (grid[0][0] !== 0 || grid[size - 1][size - 1] !== 0) {
    return -1;
  }
  const queue: [number, number, number][] = [[0, 0, 1]];
  grid[0][0] = 1;
  for (let head = 0; head < queue.length; head += 1) {
    const [row, column, length] = queue[head];
    if (row === size - 1 && column === size - 1) {
      return length;
    }
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

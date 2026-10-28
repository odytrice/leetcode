// O(rows * columns) time. Multi-source BFS spreads rot one minute per layer.
export function orangesRotting(grid: number[][]): number {
  const rows = grid.length;
  const columns = grid[0].length;
  let fresh = 0;
  let queue: [number, number][] = [];
  for (let row = 0; row < rows; row++) {
    for (let column = 0; column < columns; column++) {
      if (grid[row][column] === 1) fresh++;
      else if (grid[row][column] === 2) queue.push([row, column]);
    }
  }

  let minutes = 0;
  while (fresh > 0 && queue.length > 0) {
    minutes++;
    const nextQueue: [number, number][] = [];
    for (const [row, column] of queue) {
      for (const [nextRow, nextColumn] of [
        [row - 1, column],
        [row + 1, column],
        [row, column - 1],
        [row, column + 1],
      ]) {
        if (nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns && grid[nextRow][nextColumn] === 1) {
          grid[nextRow][nextColumn] = 2;
          fresh--;
          nextQueue.push([nextRow, nextColumn]);
        }
      }
    }
    queue = nextQueue;
  }

  return fresh === 0 ? minutes : -1;
}

// O(rows * columns) time. Multi-source BFS spreads rot one minute per layer.
export function orangesRotting(grid: number[][]): number {
  const rows = grid.length;
  const columns = grid[0].length;
  let fresh = 0;
  let queue: [number, number][] = [];
  // Count fresh oranges and queue every rotten one; they all spread at the same time.
  for (let row = 0; row < rows; row += 1) {
    for (let column = 0; column < columns; column += 1) {
      if (grid[row][column] === 1) {
        fresh += 1;
      } else if (grid[row][column] === 2) {
        queue.push([row, column]);
      }
    }
  }

  let minutes = 0;
  // Each round of the loop is one minute; stop when nothing fresh is left or nothing can spread.
  while (fresh > 0 && queue.length > 0) {
    minutes += 1;
    const nextQueue: [number, number][] = [];
    for (const [row, column] of queue) {
      for (const [nextRow, nextColumn] of [
        [row - 1, column],
        [row + 1, column],
        [row, column - 1],
        [row, column + 1],
      ]) {
        if (nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns && grid[nextRow][nextColumn] === 1) {
          // Rot the orange when it is queued so it is not counted twice.
          grid[nextRow][nextColumn] = 2;
          fresh -= 1;
          nextQueue.push([nextRow, nextColumn]);
        }
      }
    }
    queue = nextQueue;
  }

  // Any fresh orange left could never be reached.
  return fresh === 0 ? minutes : -1;
}

// O(rows * columns) time. Floods each island and keeps the largest area.
export function maxAreaOfIsland(grid: number[][]): number {
  const rows = grid.length;
  const columns = grid[0].length;
  let best = 0;
  for (let row = 0; row < rows; row += 1) {
    for (let column = 0; column < columns; column += 1) {
      if (grid[row][column] === 0) {
        continue;
      }
      let area = 0;
      const stack: [number, number][] = [[row, column]];
      grid[row][column] = 0;
      while (stack.length > 0) {
        const [currentRow, currentColumn] = stack.pop() as [number, number];
        area += 1;
        for (const [nextRow, nextColumn] of [
          [currentRow - 1, currentColumn],
          [currentRow + 1, currentColumn],
          [currentRow, currentColumn - 1],
          [currentRow, currentColumn + 1],
        ]) {
          if (nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns && grid[nextRow][nextColumn] === 1) {
            grid[nextRow][nextColumn] = 0;
            stack.push([nextRow, nextColumn]);
          }
        }
      }
      best = Math.max(best, area);
    }
  }
  return best;
}

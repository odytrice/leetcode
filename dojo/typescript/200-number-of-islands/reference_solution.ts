// O(rows * columns) time. Marks visited land as water while flooding.
export function numIslands(grid: string[][]): number {
  const rows = grid.length;
  const columns = grid[0].length;
  let count = 0;
  for (let row = 0; row < rows; row++) {
    for (let column = 0; column < columns; column++) {
      if (grid[row][column] !== "1") continue;
      count++;
      const stack: [number, number][] = [[row, column]];
      grid[row][column] = "0";
      while (stack.length > 0) {
        const [currentRow, currentColumn] = stack.pop() as [number, number];
        for (const [nextRow, nextColumn] of [
          [currentRow - 1, currentColumn],
          [currentRow + 1, currentColumn],
          [currentRow, currentColumn - 1],
          [currentRow, currentColumn + 1],
        ]) {
          if (
            nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns &&
            grid[nextRow][nextColumn] === "1"
          ) {
            grid[nextRow][nextColumn] = "0";
            stack.push([nextRow, nextColumn]);
          }
        }
      }
    }
  }
  return count;
}

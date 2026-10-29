// O(rows * columns) time. Floods backwards from each ocean and intersects.
export function pacificAtlantic(heights: number[][]): number[][] {
  const rows = heights.length;
  const columns = heights[0].length;

  // Returns every cell that can drain into one ocean, found by walking uphill from its edges.
  const reach = (pacific: boolean): Set<string> => {
    const seen = new Set<string>();
    const stack: [number, number][] = [];
    // Seed with the ocean's border cells: left and top for the Pacific, right and bottom for the Atlantic.
    for (let row = 0; row < rows; row += 1) {
      stack.push([row, pacific ? 0 : columns - 1]);
    }
    for (let column = 0; column < columns; column += 1) {
      stack.push([pacific ? 0 : rows - 1, column]);
    }
    for (const [row, column] of stack) {
      seen.add(`${row},${column}`);
    }

    while (stack.length > 0) {
      const [row, column] = stack.pop() as [number, number];
      for (const [nextRow, nextColumn] of [
        [row - 1, column],
        [row + 1, column],
        [row, column - 1],
        [row, column + 1],
      ]) {
        const key = `${nextRow},${nextColumn}`;
        if (
          nextRow >= 0 && nextColumn >= 0 && nextRow < rows && nextColumn < columns &&
          // Moving backwards against the flow, water can only come from an equal or higher cell.
          !seen.has(key) && heights[nextRow][nextColumn] >= heights[row][column]
        ) {
          // Mark a cell when it is pushed so it is never pushed twice.
          seen.add(key);
          stack.push([nextRow, nextColumn]);
        }
      }
    }
    return seen;
  };

  const pacific = reach(true);
  const atlantic = reach(false);
  const result: number[][] = [];
  // Keep the cells that both oceans can reach.
  for (const key of pacific) {
    if (!atlantic.has(key)) {
      continue;
    }
    const [row, column] = key.split(",").map(Number);
    result.push([row, column]);
  }
  return result.sort((a, b) => a[0] - b[0] || a[1] - b[1]);
}

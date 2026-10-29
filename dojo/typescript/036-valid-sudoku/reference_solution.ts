// O(81) time. One set of (unit kind, unit index, digit) catches repeats.
export function isValidSudoku(board: string[][]): boolean {
  // Holds keys like "r47": digit 7 already appears in row 4. Columns and boxes work the same way.
  const seen = new Set<string>();
  for (let row = 0; row < 9; row += 1) {
    for (let column = 0; column < 9; column += 1) {
      const digit = board[row][column];
      if (digit === ".") {
        continue;
      }
      // Number the 3x3 boxes 0 to 8, left to right and top to bottom.
      const box = Math.floor(row / 3) * 3 + Math.floor(column / 3);
      const keys = [`r${row}${digit}`, `c${column}${digit}`, `b${box}${digit}`];
      // Check all three units before recording, so a repeat in any one of them is caught.
      if (keys.some((key) => seen.has(key))) {
        return false;
      }
      for (const key of keys) {
        seen.add(key);
      }
    }
  }
  return true;
}

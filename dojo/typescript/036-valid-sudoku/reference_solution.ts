// O(81) time. One set of (unit kind, unit index, digit) catches repeats.
export function isValidSudoku(board: string[][]): boolean {
  const seen = new Set<string>();
  for (let row = 0; row < 9; row += 1) {
    for (let column = 0; column < 9; column += 1) {
      const digit = board[row][column];
      if (digit === ".") {
        continue;
      }
      const box = Math.floor(row / 3) * 3 + Math.floor(column / 3);
      const keys = [`r${row}${digit}`, `c${column}${digit}`, `b${box}${digit}`];
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

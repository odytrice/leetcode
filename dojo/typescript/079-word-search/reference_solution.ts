// O(rows * columns * 4^len(word)) time. Marks the current cell while searching.
export function exist(board: string[][], word: string): boolean {
  const rows = board.length;
  const columns = board[0].length;

  const search = (row: number, column: number, index: number): boolean => {
    if (row < 0 || column < 0 || row >= rows || column >= columns || board[row][column] !== word[index]) {
      return false;
    }
    if (index === word.length - 1) {
      return true;
    }
    const saved = board[row][column];
    board[row][column] = "";
    const found =
      search(row - 1, column, index + 1) ||
      search(row + 1, column, index + 1) ||
      search(row, column - 1, index + 1) ||
      search(row, column + 1, index + 1);
    board[row][column] = saved;
    return found;
  };

  for (let row = 0; row < rows; row += 1) {
    for (let column = 0; column < columns; column += 1) {
      if (search(row, column, 0)) {
        return true;
      }
    }
  }
  return false;
}

/** O(rows * columns * 4^len(word)) time. Marks the current cell while searching. */
class ReferenceSolution extends Solution {
    private char[][] board;
    private String word;
    private int rows;
    private int columns;

    @Override
    public boolean exist(char[][] board, String word) {
        this.board = board;
        this.word = word;
        rows = board.length;
        columns = board[0].length;
        // Any cell could hold the first letter, so try a search from each one.
        for (int row = 0; row < rows; row += 1) {
            for (int column = 0; column < columns; column += 1) {
                if (search(row, column, 0)) {
                    return true;
                }
            }
        }
        return false;
    }

    // Returns true if word[index..] can be spelled starting at this cell.
    private boolean search(int row, int column, int index) {
        // Off the board, a used cell, or the wrong letter all end this path.
        if (row < 0 || column < 0 || row >= rows || column >= columns || board[row][column] != word.charAt(index)) {
            return false;
        }
        if (index == word.length() - 1) {
            return true;
        }
        // Blank the cell so the deeper search cannot reuse it in the same path.
        char saved = board[row][column];
        board[row][column] = '\0';
        boolean found = search(row - 1, column, index + 1)
                || search(row + 1, column, index + 1)
                || search(row, column - 1, index + 1)
                || search(row, column + 1, index + 1);
        // Restore the letter so other paths can use this cell.
        board[row][column] = saved;
        return found;
    }
}

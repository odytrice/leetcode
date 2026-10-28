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
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {
                if (search(row, column, 0)) {
                    return true;
                }
            }
        }
        return false;
    }

    private boolean search(int row, int column, int index) {
        if (row < 0 || column < 0 || row >= rows || column >= columns || board[row][column] != word.charAt(index)) {
            return false;
        }
        if (index == word.length() - 1) {
            return true;
        }
        char saved = board[row][column];
        board[row][column] = '\0';
        boolean found = search(row - 1, column, index + 1)
                || search(row + 1, column, index + 1)
                || search(row, column - 1, index + 1)
                || search(row, column + 1, index + 1);
        board[row][column] = saved;
        return found;
    }
}

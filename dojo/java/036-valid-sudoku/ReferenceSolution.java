import java.util.HashSet;
import java.util.Set;

/** O(81) time. One set of (unit kind, unit index, digit) catches repeats. */
class ReferenceSolution extends Solution {
    @Override
    public boolean isValidSudoku(char[][] board) {
        // Keys like "r3" + digit record that the digit already appeared in row 3.
        Set<String> seen = new HashSet<>();
        for (int row = 0; row < 9; row += 1) {
            for (int column = 0; column < 9; column += 1) {
                char digit = board[row][column];
                if (digit == '.') {
                    continue;
                }
                // Number the 3 x 3 boxes 0 to 8, left to right and top to bottom.
                int box = row / 3 * 3 + column / 3;
                // add() returns false when the key is already present, which means a repeat.
                if (!seen.add("r" + row + digit) || !seen.add("c" + column + digit)
                        || !seen.add("b" + box + digit)) {
                    return false;
                }
            }
        }
        return true;
    }
}

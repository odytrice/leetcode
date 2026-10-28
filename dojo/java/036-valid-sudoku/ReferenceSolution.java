import java.util.HashSet;
import java.util.Set;

/** O(81) time. One set of (unit kind, unit index, digit) catches repeats. */
class ReferenceSolution extends Solution {
    @Override
    public boolean isValidSudoku(char[][] board) {
        Set<String> seen = new HashSet<>();
        for (int row = 0; row < 9; row++) {
            for (int column = 0; column < 9; column++) {
                char digit = board[row][column];
                if (digit == '.') {
                    continue;
                }
                int box = row / 3 * 3 + column / 3;
                if (!seen.add("r" + row + digit) || !seen.add("c" + column + digit)
                        || !seen.add("b" + box + digit)) {
                    return false;
                }
            }
        }
        return true;
    }
}

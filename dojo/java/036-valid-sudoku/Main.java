import java.util.Arrays;

public class Main {
    private static char[][] EmptyBoard() {
        char[][] board = new char[9][9];
        for (char[] row : board) {
            Arrays.fill(row, '.');
        }
        return board;
    }

    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("empty", () -> TestSupport.equal(true, s.isValidSudoku(EmptyBoard())));
        TestSupport.test("row duplicate", () -> {
            char[][] board = EmptyBoard();
            board[0][0] = board[0][8] = '5';
            TestSupport.equal(false, s.isValidSudoku(board));
        });
        TestSupport.test("column duplicate", () -> {
            char[][] board = EmptyBoard();
            board[0][0] = board[8][0] = '5';
            TestSupport.equal(false, s.isValidSudoku(board));
        });
        TestSupport.test("box duplicate", () -> {
            char[][] board = EmptyBoard();
            board[0][0] = board[1][1] = '5';
            TestSupport.equal(false, s.isValidSudoku(board));
        });
        TestSupport.test("separate units", () -> {
            char[][] board = EmptyBoard();
            board[0][0] = board[4][4] = '5';
            TestSupport.equal(true, s.isValidSudoku(board));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

import java.util.Arrays;

public class Main {
    private static char[][] board() {
        return new char[][] {"ABCE".toCharArray(), "SFCS".toCharArray(), "ADEE".toCharArray()};
    }

    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("found and restored", () -> {
            char[][] grid = board();
            TestSupport.equal(true, s.exist(grid, "ABCCED"));
            TestSupport.sequence(new String[] {"ABCE", "SFCS", "ADEE"},
                    new String[] {new String(grid[0]), new String(grid[1]), new String(grid[2])});
        });
        TestSupport.test("no cell reuse", () -> TestSupport.equal(false, s.exist(board(), "ABCB")));
        TestSupport.test("backtracking", () -> TestSupport.equal(true, s.exist(board(), "SEE")));
        TestSupport.test("single", () -> TestSupport.equal(true, s.exist(new char[][] {{'a'}}, "a")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

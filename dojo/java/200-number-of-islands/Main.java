import java.util.Arrays;

public class Main {
    private static char[][] grid(String... rows) {
        char[][] result = new char[rows.length][];
        for (int index = 0; index < rows.length; index++) {
            result[index] = rows[index].toCharArray();
        }
        return result;
    }

    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example one", () -> TestSupport.equal(1, s.numIslands(grid("11110", "11010", "11000", "00000"))));
        TestSupport.test("example two", () -> TestSupport.equal(3, s.numIslands(grid("11000", "11000", "00100", "00011"))));
        TestSupport.test("diagonal cells are separate", () -> TestSupport.equal(2, s.numIslands(grid("10", "01"))));
        TestSupport.test("all water", () -> TestSupport.equal(0, s.numIslands(grid("000", "000"))));
        TestSupport.test("single column", () -> TestSupport.equal(3, s.numIslands(grid("1", "1", "0", "1", "0", "1"))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

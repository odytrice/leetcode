import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.equal(3, s.maxAreaOfIsland(new int[][] {{1, 1, 0}, {0, 1, 0}, {1, 0, 1}})));
        TestSupport.test("water", () -> TestSupport.equal(0, s.maxAreaOfIsland(new int[][] {{0, 0}})));
        TestSupport.test("diagonal", () -> TestSupport.equal(1, s.maxAreaOfIsland(new int[][] {{1, 0}, {0, 1}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

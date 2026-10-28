import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("diagonal", () -> TestSupport.equal(2, s.shortestPathBinaryMatrix(new int[][] {{0, 1}, {1, 0}})));
        TestSupport.test("single", () -> TestSupport.equal(1, s.shortestPathBinaryMatrix(new int[][] {{0}})));
        TestSupport.test("blocked start",
                () -> TestSupport.equal(-1, s.shortestPathBinaryMatrix(new int[][] {{1, 0}, {0, 0}})));
        TestSupport.test("disconnected",
                () -> TestSupport.equal(-1, s.shortestPathBinaryMatrix(new int[][] {{0, 0, 0}, {1, 1, 1}, {0, 0, 0}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

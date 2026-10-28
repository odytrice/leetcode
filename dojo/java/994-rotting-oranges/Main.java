import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(4, s.orangesRotting(new int[][] {{2, 1, 1}, {1, 1, 0}, {0, 1, 1}})));
        TestSupport.test("unreachable",
                () -> TestSupport.equal(-1, s.orangesRotting(new int[][] {{2, 1, 1}, {0, 1, 1}, {1, 0, 1}})));
        TestSupport.test("no fresh", () -> TestSupport.equal(0, s.orangesRotting(new int[][] {{0, 2}})));
        TestSupport.test("multiple sources", () -> TestSupport.equal(1, s.orangesRotting(new int[][] {{2, 1, 2}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

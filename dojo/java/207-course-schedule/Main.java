import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("possible", () -> TestSupport.equal(true, s.canFinish(2, new int[][] {{1, 0}})));
        TestSupport.test("cycle", () -> TestSupport.equal(false, s.canFinish(2, new int[][] {{1, 0}, {0, 1}})));
        TestSupport.test("disconnected cycle",
                () -> TestSupport.equal(false, s.canFinish(4, new int[][] {{1, 0}, {2, 3}, {3, 2}})));
        TestSupport.test("no edges", () -> TestSupport.equal(true, s.canFinish(3, new int[][] {})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

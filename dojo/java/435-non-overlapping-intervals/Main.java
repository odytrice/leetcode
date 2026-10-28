import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.equal(1, s.eraseOverlapIntervals(new int[][] {{1, 2}, {2, 3}, {3, 4}, {1, 3}})));
        TestSupport.test("duplicates",
                () -> TestSupport.equal(2, s.eraseOverlapIntervals(new int[][] {{1, 2}, {1, 2}, {1, 2}})));
        TestSupport.test("touching",
                () -> TestSupport.equal(0, s.eraseOverlapIntervals(new int[][] {{1, 2}, {2, 3}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

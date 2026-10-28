import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.equal(2, s.findMinArrowShots(new int[][] {{10, 16}, {2, 8}, {1, 6}, {7, 12}})));
        TestSupport.test("touching",
                () -> TestSupport.equal(1, s.findMinArrowShots(new int[][] {{1, 2}, {2, 3}})));
        TestSupport.test("integer extremes", () -> TestSupport.equal(2,
                s.findMinArrowShots(new int[][] {{Integer.MIN_VALUE, -1}, {0, Integer.MAX_VALUE}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

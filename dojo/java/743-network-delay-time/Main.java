import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.equal(2, s.networkDelayTime(new int[][] {{2, 1, 1}, {2, 3, 1}, {3, 4, 1}}, 4, 2)));
        TestSupport.test("directed unreachable",
                () -> TestSupport.equal(-1, s.networkDelayTime(new int[][] {{1, 2, 1}}, 2, 2)));
        TestSupport.test("improved route",
                () -> TestSupport.equal(2, s.networkDelayTime(new int[][] {{1, 2, 10}, {1, 3, 1}, {3, 2, 1}}, 3, 1)));
        TestSupport.test("zero weight",
                () -> TestSupport.equal(0, s.networkDelayTime(new int[][] {{1, 2, 0}}, 2, 1)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

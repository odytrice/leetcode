import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(20,
                s.minCostConnectPoints(new int[][] {{0, 0}, {2, 2}, {3, 10}, {5, 2}, {7, 0}})));
        TestSupport.test("single", () -> TestSupport.equal(0, s.minCostConnectPoints(new int[][] {{4, -2}})));
        TestSupport.test("negative coordinates", () -> TestSupport.equal(18,
                s.minCostConnectPoints(new int[][] {{3, 12}, {-2, 5}, {-4, 1}})));
        TestSupport.test("coordinate limits", () -> TestSupport.equal(4_000_000,
                s.minCostConnectPoints(new int[][] {{-1_000_000, -1_000_000}, {1_000_000, 1_000_000}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

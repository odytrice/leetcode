import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.equal(2, s.minimumEffortPath(new int[][] {{1, 2, 2}, {3, 8, 2}, {5, 3, 5}})));
        TestSupport.test("single", () -> TestSupport.equal(0, s.minimumEffortPath(new int[][] {{99}})));
        TestSupport.test("max not sum",
                () -> TestSupport.equal(1, s.minimumEffortPath(new int[][] {{1, 2, 3, 4}})));
        TestSupport.test("detour", () -> TestSupport.equal(0,
                s.minimumEffortPath(new int[][] {{1, 100, 1}, {1, 100, 1}, {1, 1, 1}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

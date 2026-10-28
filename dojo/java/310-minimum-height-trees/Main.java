import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("star",
                () -> TestSupport.set(TestSupport.ints(1), s.findMinHeightTrees(4, new int[][] {{1, 0}, {1, 2}, {1, 3}})));
        TestSupport.test("two centers",
                () -> TestSupport.set(TestSupport.ints(1, 2), s.findMinHeightTrees(4, new int[][] {{0, 1}, {1, 2}, {2, 3}})));
        TestSupport.test("single", () -> TestSupport.set(TestSupport.ints(0), s.findMinHeightTrees(1, new int[][] {})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

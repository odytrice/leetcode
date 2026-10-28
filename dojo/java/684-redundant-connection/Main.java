import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("triangle", () -> TestSupport.sequence(new int[] {2, 3},
                s.findRedundantConnection(new int[][] {{1, 2}, {1, 3}, {2, 3}})));
        TestSupport.test("cycle before final edge", () -> TestSupport.sequence(new int[] {1, 4},
                s.findRedundantConnection(new int[][] {{1, 2}, {2, 3}, {3, 4}, {1, 4}, {1, 5}})));
        TestSupport.test("input order tie break", () -> TestSupport.sequence(new int[] {1, 2},
                s.findRedundantConnection(new int[][] {{2, 3}, {1, 3}, {1, 2}})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

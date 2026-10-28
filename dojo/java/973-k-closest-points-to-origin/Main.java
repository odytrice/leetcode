import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> {
            int[][] actual = s.kClosest(new int[][] {{1, 3}, {-2, 2}}, 1);
            TestSupport.equal("[[-2, 2]]", Arrays.deepToString(actual));
        });
        TestSupport.test("all points", () -> {
            int[][] actual = s.kClosest(new int[][] {{1, 2}, {3, 4}}, 2);
            TestSupport.equal("[[1, 2], [3, 4]]", Arrays.deepToString(actual));
        });
        TestSupport.test("duplicates", () -> {
            int[][] actual = s.kClosest(new int[][] {{0, 0}, {0, 0}, {1, 1}}, 2);
            TestSupport.equal("[[0, 0], [0, 0]]", Arrays.deepToString(actual));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

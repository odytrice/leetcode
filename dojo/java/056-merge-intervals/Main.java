import java.util.Arrays;

public class Main {
    private static void verify(Solution s, int[][] input, String expected) {
        TestSupport.equal(expected, Arrays.deepToString(s.merge(input)));
    }

    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> verify(s,
                new int[][] {{1, 3}, {2, 6}, {8, 10}, {15, 18}}, "[[1, 6], [8, 10], [15, 18]]"));
        TestSupport.test("touching endpoints", () -> verify(s, new int[][] {{1, 4}, {4, 5}}, "[[1, 5]]"));
        TestSupport.test("unordered and contained",
                () -> verify(s, new int[][] {{8, 10}, {1, 4}, {2, 3}}, "[[1, 4], [8, 10]]"));
        TestSupport.test("contained interval must not shrink end",
                () -> verify(s, new int[][] {{1, 10}, {2, 3}, {9, 12}}, "[[1, 12]]"));
        TestSupport.test("zero length intervals",
                () -> verify(s, new int[][] {{3, 3}, {1, 1}, {3, 4}}, "[[1, 1], [3, 4]]"));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

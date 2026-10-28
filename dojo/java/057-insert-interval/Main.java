import java.util.Arrays;

public class Main {
    private static void verify(Solution s, int[][] intervals, int[] added, String expected) {
        TestSupport.equal(expected, Arrays.deepToString(s.insert(intervals, added)));
    }

    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> verify(s, new int[][] {{1, 3}, {6, 9}}, new int[] {2, 5}, "[[1, 5], [6, 9]]"));
        TestSupport.test("bridge", () -> verify(s,
                new int[][] {{1, 2}, {3, 5}, {6, 7}, {8, 10}, {12, 16}}, new int[] {4, 8},
                "[[1, 2], [3, 10], [12, 16]]"));
        TestSupport.test("empty", () -> verify(s, new int[][] {}, new int[] {5, 7}, "[[5, 7]]"));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

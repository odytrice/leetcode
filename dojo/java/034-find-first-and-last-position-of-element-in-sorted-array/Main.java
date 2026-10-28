import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.sequence(new int[] {3, 4}, s.searchRange(new int[] {5, 7, 7, 8, 8, 10}, 8)));
        TestSupport.test("absent", () -> TestSupport.sequence(new int[] {-1, -1}, s.searchRange(new int[] {1, 3}, 2)));
        TestSupport.test("empty", () -> TestSupport.sequence(new int[] {-1, -1}, s.searchRange(new int[] {}, 0)));
        TestSupport.test("all equal",
                () -> TestSupport.sequence(new int[] {0, 2}, s.searchRange(new int[] {2, 2, 2}, 2)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

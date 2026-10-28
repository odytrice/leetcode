import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("found", () -> TestSupport.equal(2, s.searchInsert(new int[] {1, 3, 5, 6}, 5)));
        TestSupport.test("between", () -> TestSupport.equal(1, s.searchInsert(new int[] {1, 3, 5, 6}, 2)));
        TestSupport.test("after", () -> TestSupport.equal(4, s.searchInsert(new int[] {1, 3, 5, 6}, 7)));
        TestSupport.test("before", () -> TestSupport.equal(0, s.searchInsert(new int[] {1}, 0)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

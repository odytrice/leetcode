import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(4, s.lengthOfLIS(new int[] {10, 9, 2, 5, 3, 7, 101, 18})));
        TestSupport.test("equal", () -> TestSupport.equal(1, s.lengthOfLIS(new int[] {7, 7, 7})));
        TestSupport.test("decreasing", () -> TestSupport.equal(1, s.lengthOfLIS(new int[] {3, 2, 1})));
        TestSupport.test("replace tails", () -> TestSupport.equal(4, s.lengthOfLIS(new int[] {0, 1, 0, 3, 2, 3})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

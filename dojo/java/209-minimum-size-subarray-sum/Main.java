import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(2, s.minSubArrayLen(7, new int[] {2, 3, 1, 2, 4, 3})));
        TestSupport.test("one element", () -> TestSupport.equal(1, s.minSubArrayLen(4, new int[] {1, 4, 4})));
        TestSupport.test("unreachable", () -> TestSupport.equal(0, s.minSubArrayLen(11, new int[] {1, 1, 1, 1})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

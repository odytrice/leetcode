import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(true, s.checkSubarraySum(new int[] {23, 2, 4, 6, 7}, 6)));
        TestSupport.test("absent", () -> TestSupport.equal(false, s.checkSubarraySum(new int[] {23, 2, 6, 4, 7}, 13)));
        TestSupport.test("too short", () -> TestSupport.equal(false, s.checkSubarraySum(new int[] {6}, 6)));
        TestSupport.test("zero sum", () -> TestSupport.equal(true, s.checkSubarraySum(new int[] {0, 0}, 7)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

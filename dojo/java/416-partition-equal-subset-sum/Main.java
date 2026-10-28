import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(true, s.canPartition(new int[] {1, 5, 11, 5})));
        TestSupport.test("odd sum", () -> TestSupport.equal(false, s.canPartition(new int[] {1, 2, 3, 5})));
        TestSupport.test("no element reuse", () -> TestSupport.equal(false, s.canPartition(new int[] {1, 2, 5})));
        TestSupport.test("equal pair", () -> TestSupport.equal(true, s.canPartition(new int[] {100, 100})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

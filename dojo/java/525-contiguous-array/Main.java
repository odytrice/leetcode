import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(2, s.findMaxLength(new int[] {0, 1, 0})));
        TestSupport.test("all one value", () -> TestSupport.equal(0, s.findMaxLength(new int[] {1, 1, 1})));
        TestSupport.test("earliest prefix", () -> TestSupport.equal(6, s.findMaxLength(new int[] {0, 0, 1, 0, 1, 1, 0})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

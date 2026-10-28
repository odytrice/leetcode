import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(12, s.rob(new int[] {2, 7, 9, 3, 1})));
        TestSupport.test("skip large neighbor", () -> TestSupport.equal(4, s.rob(new int[] {2, 1, 1, 2})));
        TestSupport.test("single", () -> TestSupport.equal(5, s.rob(new int[] {5})));
        TestSupport.test("zeros", () -> TestSupport.equal(0, s.rob(new int[] {0, 0})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

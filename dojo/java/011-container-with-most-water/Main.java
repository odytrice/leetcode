import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(49, s.maxArea(new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7})));
        TestSupport.test("two lines", () -> TestSupport.equal(1, s.maxArea(new int[] {1, 1})));
        TestSupport.test("zero heights", () -> TestSupport.equal(0, s.maxArea(new int[] {0, 0, 0})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

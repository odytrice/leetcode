import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("rotated", () -> TestSupport.equal(1, s.findMin(new int[] {3, 4, 5, 1, 2})));
        TestSupport.test("unrotated", () -> TestSupport.equal(1, s.findMin(new int[] {1, 2, 3})));
        TestSupport.test("single", () -> TestSupport.equal(-5, s.findMin(new int[] {-5})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

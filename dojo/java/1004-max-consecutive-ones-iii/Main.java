import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(6,
                s.longestOnes(new int[] {1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0}, 2)));
        TestSupport.test("no flips", () -> TestSupport.equal(2, s.longestOnes(new int[] {1, 1, 0, 1}, 0)));
        TestSupport.test("all zeros", () -> TestSupport.equal(2, s.longestOnes(new int[] {0, 0, 0}, 2)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

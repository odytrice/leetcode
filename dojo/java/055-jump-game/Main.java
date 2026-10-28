import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("reachable", () -> TestSupport.equal(true, s.canJump(new int[] {2, 3, 1, 1, 4})));
        TestSupport.test("blocked", () -> TestSupport.equal(false, s.canJump(new int[] {3, 2, 1, 0, 4})));
        TestSupport.test("already there", () -> TestSupport.equal(true, s.canJump(new int[] {0})));
        TestSupport.test("jump over zero", () -> TestSupport.equal(true, s.canJump(new int[] {2, 0, 0})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

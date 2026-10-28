import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(1, s.lastStoneWeight(new int[] {2, 7, 4, 1, 8, 1})));
        TestSupport.test("equal pair", () -> TestSupport.equal(0, s.lastStoneWeight(new int[] {3, 3})));
        TestSupport.test("single", () -> TestSupport.equal(7, s.lastStoneWeight(new int[] {7})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

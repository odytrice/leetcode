import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(3, s.coinChange(new int[] {1, 2, 5}, 11)));
        TestSupport.test("impossible", () -> TestSupport.equal(-1, s.coinChange(new int[] {2}, 3)));
        TestSupport.test("zero", () -> TestSupport.equal(0, s.coinChange(new int[] {1}, 0)));
        TestSupport.test("greedy fails", () -> TestSupport.equal(2, s.coinChange(new int[] {1, 3, 4}, 6)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

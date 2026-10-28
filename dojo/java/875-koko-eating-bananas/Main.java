import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(4, s.minEatingSpeed(new int[] {3, 6, 7, 11}, 8)));
        TestSupport.test("one hour per pile",
                () -> TestSupport.equal(30, s.minEatingSpeed(new int[] {30, 11, 23, 4, 20}, 5)));
        TestSupport.test("large total hours", () -> TestSupport.equal(4,
                s.minEatingSpeed(new int[] {1_000_000_000, 1_000_000_000, 1_000_000_000}, 1_000_000_000)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(15,
                s.shipWithinDays(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 5)));
        TestSupport.test("one day", () -> TestSupport.equal(6, s.shipWithinDays(new int[] {1, 2, 3}, 1)));
        TestSupport.test("one per day", () -> TestSupport.equal(3, s.shipWithinDays(new int[] {1, 2, 3}, 3)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

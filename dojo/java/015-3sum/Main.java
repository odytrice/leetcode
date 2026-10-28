import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.rows(
                List.of(List.of(-1, -1, 2), List.of(-1, 0, 1)),
                s.threeSum(new int[] {-1, 0, 1, 2, -1, -4}), true));
        TestSupport.test("duplicates", () -> TestSupport.rows(
                List.of(List.of(0, 0, 0)), s.threeSum(new int[] {0, 0, 0, 0}), true));
        TestSupport.test("no answer", () -> TestSupport.equal(0, s.threeSum(new int[] {1, 2, 3}).size()));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

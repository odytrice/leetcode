import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.rows(
                List.of(List.of(2, 2, 3), List.of(7)), s.combinationSum(new int[] {2, 3, 6, 7}, 7), true));
        TestSupport.test("multiple combinations", () -> TestSupport.rows(
                List.of(List.of(2, 2, 2, 2), List.of(2, 3, 3), List.of(3, 5)),
                s.combinationSum(new int[] {2, 3, 5}, 8), true));
        TestSupport.test("impossible",
                () -> TestSupport.rows(List.of(), s.combinationSum(new int[] {2}, 1), true));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

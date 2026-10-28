import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.rows(
                List.of(List.of(), List.of(1), List.of(2), List.of(1, 2), List.of(2, 2), List.of(1, 2, 2)),
                s.subsetsWithDup(new int[] {1, 2, 2}), true));
        TestSupport.test("all same", () -> TestSupport.rows(
                List.of(List.of(), List.of(0), List.of(0, 0)), s.subsetsWithDup(new int[] {0, 0}), true));
        TestSupport.test("unsorted", () -> TestSupport.rows(
                List.of(List.of(), List.of(-1), List.of(2), List.of(-1, 2)), s.subsetsWithDup(new int[] {2, -1}), true));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

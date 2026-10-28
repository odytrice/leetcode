import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("two values", () -> TestSupport.rows(
                List.of(List.of(), List.of(1), List.of(2), List.of(1, 2)), s.subsets(new int[] {1, 2}), true));
        TestSupport.test("single", () -> TestSupport.rows(
                List.of(List.of(), List.of(0)), s.subsets(new int[] {0}), true));
        TestSupport.test("three values", () -> TestSupport.rows(
                List.of(List.of(), List.of(-1), List.of(0), List.of(1), List.of(-1, 0), List.of(-1, 1),
                        List.of(0, 1), List.of(-1, 0, 1)),
                s.subsets(new int[] {-1, 0, 1}), true));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

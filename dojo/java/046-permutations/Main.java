import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("two", () -> TestSupport.rows(List.of(List.of(1, 2), List.of(2, 1)), s.permute(new int[] {1, 2})));
        TestSupport.test("single", () -> TestSupport.rows(List.of(List.of(0)), s.permute(new int[] {0})));
        TestSupport.test("three", () -> TestSupport.rows(
                List.of(List.of(1, 2, 3), List.of(1, 3, 2), List.of(2, 1, 3), List.of(2, 3, 1),
                        List.of(3, 1, 2), List.of(3, 2, 1)),
                s.permute(new int[] {1, 2, 3})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

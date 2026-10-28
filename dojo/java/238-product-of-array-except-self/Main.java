import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.sequence(new int[] {24, 12, 8, 6}, s.productExceptSelf(new int[] {1, 2, 3, 4})));
        TestSupport.test("one zero", () -> TestSupport.sequence(new int[] {0, 0, 9, 0, 0},
                s.productExceptSelf(new int[] {-1, 1, 0, -3, 3})));
        TestSupport.test("two zeros",
                () -> TestSupport.sequence(new int[] {0, 0, 0}, s.productExceptSelf(new int[] {0, 2, 0})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

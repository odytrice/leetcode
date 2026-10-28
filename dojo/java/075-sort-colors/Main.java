import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> {
            int[] values = {2, 0, 2, 1, 1, 0};
            s.sortColors(values);
            TestSupport.sequence(new int[] {0, 0, 1, 1, 2, 2}, values);
        });
        TestSupport.test("reverse", () -> {
            int[] values = {2, 1, 0};
            s.sortColors(values);
            TestSupport.sequence(new int[] {0, 1, 2}, values);
        });
        TestSupport.test("single", () -> {
            int[] values = {2};
            s.sortColors(values);
            TestSupport.sequence(new int[] {2}, values);
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

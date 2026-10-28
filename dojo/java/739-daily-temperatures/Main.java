import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.sequence(new int[] {1, 1, 4, 2, 1, 1, 0, 0},
                s.dailyTemperatures(new int[] {73, 74, 75, 71, 69, 72, 76, 73})));
        TestSupport.test("increasing",
                () -> TestSupport.sequence(new int[] {1, 1, 1, 0}, s.dailyTemperatures(new int[] {30, 40, 50, 60})));
        TestSupport.test("equal temperatures",
                () -> TestSupport.sequence(new int[] {0, 0, 0}, s.dailyTemperatures(new int[] {70, 70, 70})));
        TestSupport.test("decreasing",
                () -> TestSupport.sequence(new int[] {0, 0, 0, 0}, s.dailyTemperatures(new int[] {90, 80, 70, 60})));
        TestSupport.test("visual walkthrough",
                () -> TestSupport.sequence(new int[] {3, 1, 1, 0}, s.dailyTemperatures(new int[] {73, 71, 72, 74})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

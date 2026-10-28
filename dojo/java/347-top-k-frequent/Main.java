import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.set(TestSupport.ints(1, 2), s.topKFrequent(new int[] {1, 1, 1, 2, 2, 3}, 2)));
        TestSupport.test("single element", () -> TestSupport.set(TestSupport.ints(1), s.topKFrequent(new int[] {1}, 1)));
        TestSupport.test("negative values",
                () -> TestSupport.set(TestSupport.ints(-1, 4), s.topKFrequent(new int[] {4, 4, 4, -1, -1, 2}, 2)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

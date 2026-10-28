import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(5, s.findKthLargest(new int[] {3, 2, 1, 5, 6, 4}, 2)));
        TestSupport.test("duplicates",
                () -> TestSupport.equal(4, s.findKthLargest(new int[] {3, 2, 3, 1, 2, 4, 5, 5, 6}, 4)));
        TestSupport.test("negative", () -> TestSupport.equal(-3, s.findKthLargest(new int[] {-1, -3, -2}, 3)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(2, s.threeSumClosest(new int[] {-1, 2, 1, -4}, 1)));
        TestSupport.test("zeros", () -> TestSupport.equal(0, s.threeSumClosest(new int[] {0, 0, 0}, 1)));
        TestSupport.test("exact", () -> TestSupport.equal(3, s.threeSumClosest(new int[] {1, 1, 1, 0}, 3)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

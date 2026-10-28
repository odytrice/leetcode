import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("rotated", () -> TestSupport.equal(4, s.search(new int[] {4, 5, 6, 7, 0, 1, 2}, 0)));
        TestSupport.test("absent", () -> TestSupport.equal(-1, s.search(new int[] {4, 5, 6, 7, 0, 1, 2}, 3)));
        TestSupport.test("unrotated", () -> TestSupport.equal(2, s.search(new int[] {1, 2, 3}, 3)));
        TestSupport.test("single", () -> TestSupport.equal(0, s.search(new int[] {1}, 1)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

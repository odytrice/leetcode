import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(28, s.uniquePaths(3, 7)));
        TestSupport.test("one row", () -> TestSupport.equal(1, s.uniquePaths(1, 100)));
        TestSupport.test("one column", () -> TestSupport.equal(1, s.uniquePaths(100, 1)));
        TestSupport.test("square", () -> TestSupport.equal(6, s.uniquePaths(3, 3)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(3, s.maxDepth(TreeNode.from(3, 9, 20, null, null, 15, 7))));
        TestSupport.test("empty", () -> TestSupport.equal(0, s.maxDepth(null)));
        TestSupport.test("skewed", () -> TestSupport.equal(3, s.maxDepth(TreeNode.from(1, null, 2, null, 3))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("valid", () -> TestSupport.equal(true, s.isValidBST(TreeNode.from(2, 1, 3))));
        TestSupport.test("ancestor violation",
                () -> TestSupport.equal(false, s.isValidBST(TreeNode.from(5, 1, 7, null, null, 4, 8))));
        TestSupport.test("duplicate", () -> TestSupport.equal(false, s.isValidBST(TreeNode.from(2, 2, 3))));
        TestSupport.test("integer limits",
                () -> TestSupport.equal(true, s.isValidBST(TreeNode.from(0, Integer.MIN_VALUE, Integer.MAX_VALUE))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

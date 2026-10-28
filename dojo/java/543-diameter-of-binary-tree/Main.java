import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(3, s.diameterOfBinaryTree(TreeNode.from(1, 2, 3, 4, 5))));
        TestSupport.test("single", () -> TestSupport.equal(0, s.diameterOfBinaryTree(new TreeNode(1))));
        TestSupport.test("below root",
                () -> TestSupport.equal(4, s.diameterOfBinaryTree(TreeNode.from(1, 2, null, 3, 4, 5, null, null, 6))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

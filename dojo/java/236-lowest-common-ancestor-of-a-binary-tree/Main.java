import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("different subtrees", () -> {
            TreeNode root = TreeNode.from(3, 5, 1);
            TestSupport.check(s.lowestCommonAncestor(root, root.left, root.right) == root);
        });
        TestSupport.test("ancestor is target", () -> {
            TreeNode root = TreeNode.from(3, 5, 1, 6, 2);
            TestSupport.check(s.lowestCommonAncestor(root, root.left, root.left.right) == root.left);
        });
        TestSupport.test("two nodes", () -> {
            TreeNode root = TreeNode.from(1, 2);
            TestSupport.check(s.lowestCommonAncestor(root, root, root.left) == root);
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

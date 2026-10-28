import java.util.Arrays;

public class Main {
    private static String shape(TreeNode node) {
        if (node == null) {
            return "#";
        }
        return node.val + "(" + shape(node.left) + "," + shape(node.right) + ")";
    }

    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal(
                shape(TreeNode.from(3, 9, 20, null, null, 15, 7)),
                shape(s.buildTree(new int[] {3, 9, 20, 15, 7}, new int[] {9, 3, 15, 20, 7}))));
        TestSupport.test("left chain",
                () -> TestSupport.equal("3(2(1(#,#),#),#)", shape(s.buildTree(new int[] {3, 2, 1}, new int[] {1, 2, 3}))));
        TestSupport.test("single", () -> TestSupport.equal("-1(#,#)", shape(s.buildTree(new int[] {-1}, new int[] {-1}))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("minimum",
                () -> TestSupport.equal(1, s.kthSmallest(TreeNode.from(3, 1, 4, null, 2), 1)));
        TestSupport.test("interior",
                () -> TestSupport.equal(3, s.kthSmallest(TreeNode.from(5, 3, 6, 2, 4, null, null, 1), 3)));
        TestSupport.test("maximum",
                () -> TestSupport.equal(4, s.kthSmallest(TreeNode.from(3, 1, 4, null, 2), 4)));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

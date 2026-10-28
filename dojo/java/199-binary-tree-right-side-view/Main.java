import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example",
                () -> TestSupport.sequence(TestSupport.ints(1, 3, 4), s.rightSideView(TreeNode.from(1, 2, 3, null, 5, null, 4))));
        TestSupport.test("left continues",
                () -> TestSupport.sequence(TestSupport.ints(1, 3, 4), s.rightSideView(TreeNode.from(1, 2, 3, 4))));
        TestSupport.test("empty", () -> TestSupport.equal(0, s.rightSideView(null).size()));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

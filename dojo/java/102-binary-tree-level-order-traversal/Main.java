import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.rows(
                List.of(List.of(3), List.of(9, 20), List.of(15, 7)),
                s.levelOrder(TreeNode.from(3, 9, 20, null, null, 15, 7))));
        TestSupport.test("empty", () -> TestSupport.equal(0, s.levelOrder(null).size()));
        TestSupport.test("single", () -> TestSupport.rows(List.of(List.of(1)), s.levelOrder(new TreeNode(1))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

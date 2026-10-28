import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.sequence(new int[] {3, 2, 1},
                ListNode.values(s.reverseList(ListNode.from(1, 2, 3)))));
        TestSupport.test("empty", () -> TestSupport.check(s.reverseList(null) == null));
        TestSupport.test("single", () -> {
            ListNode node = new ListNode(7);
            TestSupport.check(s.reverseList(node) == node);
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

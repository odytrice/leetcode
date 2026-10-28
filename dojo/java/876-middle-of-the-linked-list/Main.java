import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("odd", () -> {
            ListNode head = ListNode.from(1, 2, 3, 4, 5);
            TestSupport.check(s.middleNode(head) == head.next.next);
        });
        TestSupport.test("even", () -> {
            ListNode head = ListNode.from(1, 2, 3, 4);
            TestSupport.check(s.middleNode(head) == head.next.next);
        });
        TestSupport.test("single", () -> {
            ListNode head = new ListNode(1);
            TestSupport.check(s.middleNode(head) == head);
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

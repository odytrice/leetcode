import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.sequence(new int[] {1, 2, 3, 5},
                ListNode.values(s.removeNthFromEnd(ListNode.from(1, 2, 3, 4, 5), 2))));
        TestSupport.test("remove head", () -> {
            ListNode head = ListNode.from(1, 2);
            TestSupport.check(s.removeNthFromEnd(head, 2) == head.next);
        });
        TestSupport.test("remove only node", () -> TestSupport.check(s.removeNthFromEnd(new ListNode(1), 1) == null));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

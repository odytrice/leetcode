import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("cycle entry", () -> {
            ListNode head = ListNode.from(3, 2, 0, -4);
            ListNode entry = head.next;
            head.next.next.next.next = entry;
            TestSupport.check(s.detectCycle(head) == entry);
            TestSupport.check(head.next == entry);
        });
        TestSupport.test("no cycle", () -> TestSupport.check(s.detectCycle(ListNode.from(1, 2)) == null));
        TestSupport.test("self cycle", () -> {
            ListNode head = new ListNode(1);
            head.next = head;
            TestSupport.check(s.detectCycle(head) == head);
        });
        TestSupport.test("empty", () -> TestSupport.check(s.detectCycle(null) == null));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

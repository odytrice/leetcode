import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("odd", () -> {
            ListNode head = ListNode.from(1, 2, 3, 4, 5);
            s.reorderList(head);
            TestSupport.sequence(new int[] {1, 5, 2, 4, 3}, ListNode.values(head));
        });
        TestSupport.test("even", () -> {
            ListNode head = ListNode.from(1, 2, 3, 4);
            s.reorderList(head);
            TestSupport.sequence(new int[] {1, 4, 2, 3}, ListNode.values(head));
        });
        TestSupport.test("single", () -> {
            ListNode head = ListNode.from(1);
            s.reorderList(head);
            TestSupport.sequence(new int[] {1}, ListNode.values(head));
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

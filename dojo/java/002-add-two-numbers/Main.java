import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.sequence(new int[] {7, 0, 8},
                ListNode.values(s.addTwoNumbers(ListNode.from(2, 4, 3), ListNode.from(5, 6, 4)))));
        TestSupport.test("carry chain", () -> TestSupport.sequence(new int[] {0, 0, 0, 1},
                ListNode.values(s.addTwoNumbers(ListNode.from(9, 9, 9), new ListNode(1)))));
        TestSupport.test("zero",
                () -> TestSupport.sequence(new int[] {0}, ListNode.values(s.addTwoNumbers(new ListNode(0), new ListNode(0)))));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

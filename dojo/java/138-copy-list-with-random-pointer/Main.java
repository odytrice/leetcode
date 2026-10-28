import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("cross pointers and duplicate values", () -> {
            RandomNode first = new RandomNode(7);
            RandomNode second = new RandomNode(7);
            first.next = second;
            first.random = second;
            second.random = first;

            RandomNode copy = s.copyRandomList(first);
            TestSupport.check(copy != first && copy.next != second, "copies must be new nodes");
            TestSupport.equal(7, copy.val);
            TestSupport.equal(7, copy.next.val);
            TestSupport.check(copy.random == copy.next && copy.next.random == copy, "random pointers must be copied");
            TestSupport.check(first.next == second && second.random == first, "input must not change");
        });
        TestSupport.test("self random", () -> {
            RandomNode node = new RandomNode(1);
            node.random = node;
            RandomNode copy = s.copyRandomList(node);
            TestSupport.check(copy != node && copy.random == copy && copy.next == null, "self random must be copied");
        });
        TestSupport.test("empty", () -> TestSupport.check(s.copyRandomList(null) == null, "empty list"));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}

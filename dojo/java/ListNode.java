import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

/** LeetCode supplies this type. Kept here so each drill compiles independently. */
public class ListNode {
    public int val;
    public ListNode next;

    public ListNode() {
    }

    public ListNode(int val) {
        this.val = val;
    }

    public ListNode(int val, ListNode next) {
        this.val = val;
        this.next = next;
    }

    public static ListNode from(int... values) {
        ListNode head = null;
        for (int i = values.length - 1; i >= 0; i--) {
            head = new ListNode(values[i], head);
        }
        return head;
    }

    public static int[] values(ListNode head) {
        List<Integer> result = new ArrayList<>();
        Set<ListNode> seen = new HashSet<>();
        for (ListNode node = head; node != null; node = node.next) {
            if (!seen.add(node)) {
                throw new IllegalStateException("Unexpected cycle in result");
            }
            result.add(node.val);
        }
        return result.stream().mapToInt(Integer::intValue).toArray();
    }
}

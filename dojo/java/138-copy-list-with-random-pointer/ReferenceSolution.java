import java.util.HashMap;
import java.util.Map;

/** O(n) time and space. Copies every node first, then wires the pointers. */
class ReferenceSolution extends Solution {
    @Override
    public RandomNode copyRandomList(RandomNode head) {
        Map<RandomNode, RandomNode> copies = new HashMap<>();
        for (RandomNode node = head; node != null; node = node.next) {
            copies.put(node, new RandomNode(node.val));
        }
        for (RandomNode node = head; node != null; node = node.next) {
            RandomNode copy = copies.get(node);
            copy.next = node.next == null ? null : copies.get(node.next);
            copy.random = node.random == null ? null : copies.get(node.random);
        }
        return head == null ? null : copies.get(head);
    }
}

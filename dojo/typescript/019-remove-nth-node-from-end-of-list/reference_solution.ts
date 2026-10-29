import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. A lead of n nodes puts slow on the node before the target.
export function removeNthFromEnd(head: ListNode, n: number): ListNode | null {
  // The dummy node lets us remove the head with the same code as any other node.
  const dummy = new ListNode(0, head);
  let fast: ListNode | null = dummy;
  let slow: ListNode = dummy;
  // Give fast a head start of n + 1 nodes.
  for (let step = 0; step <= n; step += 1) {
    fast = fast === null ? null : fast.next;
  }
  // When fast runs off the end, slow sits just before the node to remove.
  while (fast !== null) {
    fast = fast.next;
    slow = slow.next as ListNode;
  }
  // Unlink the target by skipping over it.
  slow.next = slow.next === null ? null : slow.next.next;
  return dummy.next;
}

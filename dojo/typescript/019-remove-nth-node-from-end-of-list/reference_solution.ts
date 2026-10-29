import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. A lead of n nodes puts slow on the node before the target.
export function removeNthFromEnd(head: ListNode, n: number): ListNode | null {
  const dummy = new ListNode(0, head);
  let fast: ListNode | null = dummy;
  let slow: ListNode = dummy;
  for (let step = 0; step <= n; step += 1) {
    fast = fast === null ? null : fast.next;
  }
  while (fast !== null) {
    fast = fast.next;
    slow = slow.next as ListNode;
  }
  slow.next = slow.next === null ? null : slow.next.next;
  return dummy.next;
}

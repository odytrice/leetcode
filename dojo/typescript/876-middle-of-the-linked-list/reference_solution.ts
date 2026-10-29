import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. The fast pointer travels twice as far.
export function middleNode(head: ListNode): ListNode {
  let slow: ListNode = head;
  let fast: ListNode | null = head;
  // When fast reaches the end, slow has gone half as far; with two middles it lands on the second.
  while (fast !== null && fast.next !== null) {
    slow = slow.next as ListNode;
    fast = fast.next.next;
  }
  return slow;
}

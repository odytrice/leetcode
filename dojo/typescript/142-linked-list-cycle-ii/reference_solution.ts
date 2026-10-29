import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. After the meeting, walk from the head and the meeting point.
export function detectCycle(head: ListNode | null): ListNode | null {
  let slow = head;
  let fast = head;
  while (fast !== null && fast.next !== null) {
    slow = slow?.next ?? null;
    fast = fast.next.next;
    if (slow !== fast) {
      continue;
    }
    slow = head;
    while (slow !== fast) {
      slow = slow?.next ?? null;
      fast = fast?.next ?? null;
    }
    return slow;
  }
  return null;
}

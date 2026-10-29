import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. After the meeting, walk from the head and the meeting point.
export function detectCycle(head: ListNode | null): ListNode | null {
  let slow = head;
  let fast = head;
  // Phase 1: slow moves one step and fast two; they meet only if there is a cycle.
  while (fast !== null && fast.next !== null) {
    slow = slow?.next ?? null;
    fast = fast.next.next;
    if (slow !== fast) {
      continue;
    }
    // Phase 2: the head and the meeting point are equally far from the cycle start.
    slow = head;
    while (slow !== fast) {
      slow = slow?.next ?? null;
      fast = fast?.next ?? null;
    }
    return slow;
  }
  // fast ran off the end, so there is no cycle.
  return null;
}

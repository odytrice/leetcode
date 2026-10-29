import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. Splits at the middle, reverses the tail, then merges.
export function reorderList(head: ListNode): void {
  // Phase 1: when fast reaches the end, slow is at the end of the first half.
  let slow: ListNode = head;
  let fast: ListNode = head;
  while (fast.next !== null && fast.next.next !== null) {
    slow = slow.next as ListNode;
    fast = fast.next.next;
  }

  // Phase 2: cut the list in two and reverse the second half.
  let right: ListNode | null = slow.next;
  slow.next = null;
  let reversedTail: ListNode | null = null;
  while (right !== null) {
    const following = right.next;
    right.next = reversedTail;
    reversedTail = right;
    right = following;
  }

  // Phase 3: alternate nodes from the front half and the reversed back half.
  let left: ListNode | null = head;
  while (reversedTail !== null) {
    const nextLeft = left.next;
    const nextRight = reversedTail.next;
    left.next = reversedTail;
    reversedTail.next = nextLeft;
    left = nextLeft;
    reversedTail = nextRight;
  }
}

import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. Splits at the middle, reverses the tail, then merges.
export function reorderList(head: ListNode): void {
  let slow: ListNode = head;
  let fast: ListNode = head;
  while (fast.next !== null && fast.next.next !== null) {
    slow = slow.next as ListNode;
    fast = fast.next.next;
  }

  let right: ListNode | null = slow.next;
  slow.next = null;
  let reversedTail: ListNode | null = null;
  while (right !== null) {
    const following = right.next;
    right.next = reversedTail;
    reversedTail = right;
    right = following;
  }

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

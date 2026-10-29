import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. Points each node at the previous one.
export function reverseList(head: ListNode | null): ListNode | null {
  let previous: ListNode | null = null;
  while (head !== null) {
    // Save the rest of the list before pointing this node backwards.
    const following = head.next;
    head.next = previous;
    previous = head;
    head = following;
  }
  // previous ends on the old tail, which is the new head.
  return previous;
}

import { ListNode } from "../shared.ts";

// O(n) time, O(1) space. Points each node at the previous one.
export function reverseList(head: ListNode | null): ListNode | null {
  let previous: ListNode | null = null;
  while (head !== null) {
    const following = head.next;
    head.next = previous;
    previous = head;
    head = following;
  }
  return previous;
}

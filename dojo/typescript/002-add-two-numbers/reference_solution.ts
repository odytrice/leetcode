import { ListNode } from "../shared.ts";

// O(max(m, n)) time. Adds column by column with a carry.
export function addTwoNumbers(l1: ListNode, l2: ListNode): ListNode {
  const dummy = new ListNode(0);
  let tail: ListNode = dummy;
  let first: ListNode | null = l1;
  let second: ListNode | null = l2;
  let carry = 0;
  while (first !== null || second !== null || carry !== 0) {
    const total = (first?.val ?? 0) + (second?.val ?? 0) + carry;
    tail.next = new ListNode(total % 10);
    tail = tail.next;
    carry = Math.floor(total / 10);
    first = first === null ? null : first.next;
    second = second === null ? null : second.next;
  }
  return dummy.next as ListNode;
}

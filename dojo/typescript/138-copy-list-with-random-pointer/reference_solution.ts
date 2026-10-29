import { RandomNode } from "./solution.ts";

// O(n) time and space. Copy every node first, then wire the pointers.
export function copyRandomList(head: RandomNode | null): RandomNode | null {
  // Maps each original node to its copy.
  const copies = new Map<RandomNode, RandomNode>();
  // Pass 1: create every copy so random pointers have something to point at.
  for (let node = head; node !== null; node = node.next) {
    copies.set(node, new RandomNode(node.val));
  }
  // Pass 2: point each copy's next and random at the matching copies.
  for (let node = head; node !== null; node = node.next) {
    const copy = copies.get(node) as RandomNode;
    copy.next = node.next === null ? null : (copies.get(node.next) as RandomNode);
    copy.random = node.random === null ? null : (copies.get(node.random) as RandomNode);
  }
  return head === null ? null : (copies.get(head) as RandomNode);
}

import { TreeNode } from "../shared.ts";

// O(height + k) time. Stops the in-order walk at the kth value.
export function kthSmallest(root: TreeNode, k: number): number {
  const stack: TreeNode[] = [];
  let node: TreeNode | null = root;
  while (node !== null || stack.length > 0) {
    // Walk as far left as possible; those nodes come first in order.
    while (node !== null) {
      stack.push(node);
      node = node.left;
    }
    const current = stack.pop() as TreeNode;
    // Values come out in sorted order, so count down to the kth one.
    k -= 1;
    if (k === 0) {
      return current.val;
    }
    // Continue with the right subtree, which holds the next larger values.
    node = current.right;
  }
  throw new Error("k is out of range");
}

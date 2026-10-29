import { TreeNode } from "../shared.ts";

// O(n) time. An in-order traversal of a BST is strictly increasing.
export function isValidBST(root: TreeNode | null): boolean {
  const stack: TreeNode[] = [];
  // Starts below any value a node can hold.
  let previous = -Number.MAX_SAFE_INTEGER * 2;
  let node = root;
  while (node !== null || stack.length > 0) {
    // Walk as far left as possible; those nodes come first in order.
    while (node !== null) {
      stack.push(node);
      node = node.left;
    }
    const current = stack.pop() as TreeNode;
    // In-order values must strictly increase, so a value not above the previous one breaks the BST.
    if (current.val <= previous) {
      return false;
    }
    previous = current.val;
    // After visiting a node, continue with its right subtree.
    node = current.right;
  }
  return true;
}

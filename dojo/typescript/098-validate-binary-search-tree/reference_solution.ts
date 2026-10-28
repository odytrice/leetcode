import { TreeNode } from "../shared.ts";

// O(n) time. An in-order traversal of a BST is strictly increasing.
export function isValidBST(root: TreeNode | null): boolean {
  const stack: TreeNode[] = [];
  let previous = -Number.MAX_SAFE_INTEGER * 2;
  let node = root;
  while (node !== null || stack.length > 0) {
    while (node !== null) {
      stack.push(node);
      node = node.left;
    }
    const current = stack.pop() as TreeNode;
    if (current.val <= previous) return false;
    previous = current.val;
    node = current.right;
  }
  return true;
}

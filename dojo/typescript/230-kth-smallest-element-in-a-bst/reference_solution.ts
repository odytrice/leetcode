import { TreeNode } from "../shared.ts";

// O(height + k) time. Stops the in-order walk at the kth value.
export function kthSmallest(root: TreeNode, k: number): number {
  const stack: TreeNode[] = [];
  let node: TreeNode | null = root;
  while (node !== null || stack.length > 0) {
    while (node !== null) {
      stack.push(node);
      node = node.left;
    }
    const current = stack.pop() as TreeNode;
    k--;
    if (k === 0) return current.val;
    node = current.right;
  }
  throw new Error("k is out of range");
}

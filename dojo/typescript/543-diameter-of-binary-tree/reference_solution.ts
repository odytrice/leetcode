import { TreeNode } from "../shared.ts";

// O(n) time. Height of each child, summed at every node, is the path through it.
export function diameterOfBinaryTree(root: TreeNode | null): number {
  let best = 0;
  // Returns the height of a subtree in nodes, and updates best along the way.
  const height = (node: TreeNode | null): number => {
    if (node === null) {
      return 0;
    }
    const left = height(node.left);
    const right = height(node.right);
    // The longest path through this node joins its deepest left and right paths.
    best = Math.max(best, left + right);
    return 1 + Math.max(left, right);
  };
  height(root);
  return best;
}

import { TreeNode } from "../shared.ts";

// O(n) time. The last node of each level is the visible one.
export function rightSideView(root: TreeNode | null): number[] {
  const result: number[] = [];
  // level holds the nodes at the current depth, left to right.
  let level: TreeNode[] = root === null ? [] : [root];
  while (level.length > 0) {
    // The rightmost node of the level is the one visible from the right.
    result.push(level[level.length - 1].val);
    const next: TreeNode[] = [];
    for (const node of level) {
      if (node.left !== null) {
        next.push(node.left);
      }
      if (node.right !== null) {
        next.push(node.right);
      }
    }
    level = next;
  }
  return result;
}

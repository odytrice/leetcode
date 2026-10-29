import { TreeNode } from "../shared.ts";

// O(n) time. Drains the queue one level at a time.
export function levelOrder(root: TreeNode | null): number[][] {
  const result: number[][] = [];
  // level holds every node at the current depth, left to right.
  let level: TreeNode[] = root === null ? [] : [root];
  while (level.length > 0) {
    result.push(level.map((node) => node.val));
    // Collect the children in order; they form the next level.
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

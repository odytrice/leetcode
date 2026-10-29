import { TreeNode } from "../shared.ts";

// O(n) time. BFS counts one level per queue drain.
export function maxDepth(root: TreeNode | null): number {
  let depth = 0;
  // level holds every node at the current depth.
  let level: TreeNode[] = root === null ? [] : [root];
  while (level.length > 0) {
    // Each non-empty level adds one to the depth.
    depth += 1;
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
  return depth;
}

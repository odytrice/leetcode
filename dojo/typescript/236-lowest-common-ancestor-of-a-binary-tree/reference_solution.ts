import { TreeNode } from "../shared.ts";

// O(n) time. Records every parent, then walks up from both nodes.
export function lowestCommonAncestor(root: TreeNode, p: TreeNode, q: TreeNode): TreeNode {
  // Phase 1: map every node to its parent; the root has none.
  const parents = new Map<TreeNode, TreeNode | null>([[root, null]]);
  const stack: TreeNode[] = [root];
  while (stack.length > 0) {
    const node = stack.pop() as TreeNode;
    for (const child of [node.left, node.right]) {
      if (child !== null) {
        parents.set(child, node);
        stack.push(child);
      }
    }
  }

  // Phase 2: collect p and all of its ancestors.
  const ancestors = new Set<TreeNode>();
  for (let node: TreeNode | null | undefined = p; node != null; node = parents.get(node)) {
    ancestors.add(node);
  }

  // Phase 3: the first ancestor of q that is also an ancestor of p is the answer.
  let node: TreeNode | null | undefined = q;
  while (node != null && !ancestors.has(node)) {
    node = parents.get(node);
  }
  return node as TreeNode;
}
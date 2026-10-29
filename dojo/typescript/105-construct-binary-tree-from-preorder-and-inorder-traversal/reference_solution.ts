import { TreeNode } from "../shared.ts";

// O(n) time. Iterative: attach each preorder node, popping finished left chains.
export function buildTree(preorder: number[], inorder: number[]): TreeNode {
  const root = new TreeNode(preorder[0]);
  // The stack holds the current chain of nodes still waiting for a right child.
  const stack: TreeNode[] = [root];
  // index points at the next inorder value we have not yet finished.
  let index = 0;
  for (let position = 1; position < preorder.length; position += 1) {
    let parent = stack[stack.length - 1];
    const node = new TreeNode(preorder[position]);
    // If the top is not the next inorder value, its left subtree is not done, so the node goes left.
    if (parent.val !== inorder[index]) {
      parent.left = node;
    } else {
      // Pop nodes whose inorder turn has come; the last one popped gets the new node as its right child.
      while (stack.length > 0 && stack[stack.length - 1].val === inorder[index]) {
        parent = stack.pop() as TreeNode;
        index += 1;
      }
      parent.right = node;
    }
    stack.push(node);
  }
  return root;
}

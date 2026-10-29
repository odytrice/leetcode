import { TreeNode } from "../shared.ts";

// O(n) time. Iterative: attach each preorder node, popping finished left chains.
export function buildTree(preorder: number[], inorder: number[]): TreeNode {
  const root = new TreeNode(preorder[0]);
  const stack: TreeNode[] = [root];
  let index = 0;
  for (let position = 1; position < preorder.length; position += 1) {
    let parent = stack[stack.length - 1];
    const node = new TreeNode(preorder[position]);
    if (parent.val !== inorder[index]) {
      parent.left = node;
    } else {
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

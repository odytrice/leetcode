import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class ReferenceSolution:
    # O(n) time. Iterative: attach each preorder node, popping finished left chains.
    def build_tree(self, preorder: list[int], inorder: list[int]) -> TreeNode:
        root = TreeNode(preorder[0])
        stack = [root]
        index = 0
        for value in preorder[1:]:
            parent = stack[-1]
            node = TreeNode(value)
            if parent.val != inorder[index]:
                parent.left = node
            else:
                while stack and stack[-1].val == inorder[index]:
                    parent = stack.pop()
                    index += 1
                parent.right = node
            stack.append(node)
        return root

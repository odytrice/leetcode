import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class ReferenceSolution:
    # O(n) time. An in-order traversal of a BST is strictly increasing.
    def is_valid_bst(self, root: TreeNode | None) -> bool:
        stack: list[TreeNode] = []
        previous = -2**63
        node = root
        while node is not None or stack:
            while node is not None:
                stack.append(node)
                node = node.left
            node = stack.pop()
            if node.val <= previous:
                return False
            previous = node.val
            node = node.right
        return True

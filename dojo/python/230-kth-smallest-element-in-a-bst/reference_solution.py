import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class ReferenceSolution:
    # O(height + k) time. Stop the in-order walk at the kth value.
    def kth_smallest(self, root: TreeNode, k: int) -> int:
        stack: list[TreeNode] = []
        node: TreeNode | None = root
        while node is not None or stack:
            while node is not None:
                stack.append(node)
                node = node.left
            node = stack.pop()
            k -= 1
            if k == 0:
                return node.val
            node = node.right
        raise ValueError("k is out of range")

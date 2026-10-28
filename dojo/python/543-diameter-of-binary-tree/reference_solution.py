import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class ReferenceSolution:
    # O(n) time. Height of each child, summed at every node, is the path through it.
    def diameter_of_binary_tree(self, root: TreeNode | None) -> int:
        best = 0

        def height(node: TreeNode | None) -> int:
            nonlocal best
            if node is None:
                return 0
            left = height(node.left)
            right = height(node.right)
            best = max(best, left + right)
            return 1 + max(left, right)

        height(root)
        return best

import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class ReferenceSolution:
    # O(n) time. BFS counts one level per queue drain.
    def max_depth(self, root: TreeNode | None) -> int:
        depth = 0
        level = [root] if root is not None else []
        while level:
            depth += 1
            level = [child for node in level for child in (node.left, node.right) if child is not None]
        return depth

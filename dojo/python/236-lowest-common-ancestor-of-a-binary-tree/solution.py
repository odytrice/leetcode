import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def lowest_common_ancestor(self, root: TreeNode, p: TreeNode, q: TreeNode) -> TreeNode:
        raise NotImplementedError

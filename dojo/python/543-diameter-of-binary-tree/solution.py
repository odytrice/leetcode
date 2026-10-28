import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def diameter_of_binary_tree(self, root: TreeNode | None) -> int:
        raise NotImplementedError

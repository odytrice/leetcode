import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def max_depth(self, root: TreeNode | None) -> int:
        raise NotImplementedError

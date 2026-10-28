import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def level_order(self, root: TreeNode | None) -> list[list[int]]:
        raise NotImplementedError

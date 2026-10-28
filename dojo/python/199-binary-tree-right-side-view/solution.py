import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def right_side_view(self, root: TreeNode | None) -> list[int]:
        raise NotImplementedError

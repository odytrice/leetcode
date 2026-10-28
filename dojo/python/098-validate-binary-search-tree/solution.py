import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def is_valid_bst(self, root: TreeNode | None) -> bool:
        raise NotImplementedError

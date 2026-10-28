import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def kth_smallest(self, root: TreeNode, k: int) -> int:
        raise NotImplementedError

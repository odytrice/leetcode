import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import TreeNode


class Solution:
    def build_tree(self, preorder: list[int], inorder: list[int]) -> TreeNode:
        raise NotImplementedError

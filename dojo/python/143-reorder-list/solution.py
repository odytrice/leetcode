import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class Solution:
    def reorder_list(self, head: ListNode) -> None:
        raise NotImplementedError

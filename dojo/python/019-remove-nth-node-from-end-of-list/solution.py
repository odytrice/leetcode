import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class Solution:
    def remove_nth_from_end(self, head: ListNode, n: int) -> ListNode | None:
        raise NotImplementedError

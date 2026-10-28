import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class Solution:
    def detect_cycle(self, head: ListNode | None) -> ListNode | None:
        raise NotImplementedError

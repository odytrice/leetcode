import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class ReferenceSolution:
    # O(n) time, O(1) space. Point each node at the previous one.
    def reverse_list(self, head: ListNode | None) -> ListNode | None:
        previous: ListNode | None = None
        while head is not None:
            following = head.next
            head.next = previous
            previous = head
            head = following
        return previous

import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class ReferenceSolution:
    # O(n) time, O(1) space. Split at the middle, reverse the tail, then merge.
    def reorder_list(self, head: ListNode) -> None:
        slow = fast = head
        while fast.next is not None and fast.next.next is not None:
            slow = slow.next  # type: ignore[assignment]
            fast = fast.next.next

        right = slow.next
        slow.next = None
        reversed_tail: ListNode | None = None
        while right is not None:
            following = right.next
            right.next = reversed_tail
            reversed_tail = right
            right = following

        left: ListNode | None = head
        while reversed_tail is not None:
            next_left = left.next
            next_right = reversed_tail.next
            left.next = reversed_tail
            reversed_tail.next = next_left
            left = next_left
            reversed_tail = next_right

import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class ReferenceSolution:
    # O(max(m, n)) time. Add column by column with a carry.
    def add_two_numbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        dummy = ListNode(0)
        tail = dummy
        first: ListNode | None = l1
        second: ListNode | None = l2
        carry = 0
        while first is not None or second is not None or carry:
            total = (first.val if first else 0) + (second.val if second else 0) + carry
            tail.next = ListNode(total % 10)
            tail = tail.next
            carry = total // 10
            first = first.next if first else None
            second = second.next if second else None
        return dummy.next

import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class DetectCycleTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_cycle_entry(self) -> None:
        head = ListNode.from_values([3, 2, 0, -4])
        entry = head.next
        head.next.next.next.next = entry
        self.assertIs(self.solution().detect_cycle(head), entry)
        self.assertIs(head.next, entry)

    def test_no_cycle(self) -> None:
        self.assertIsNone(self.solution().detect_cycle(ListNode.from_values([1, 2])))

    def test_self_cycle(self) -> None:
        head = ListNode(1)
        head.next = head
        self.assertIs(self.solution().detect_cycle(head), head)

    def test_empty(self) -> None:
        self.assertIsNone(self.solution().detect_cycle(None))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

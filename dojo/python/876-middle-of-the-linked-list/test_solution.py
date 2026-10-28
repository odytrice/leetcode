import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class MiddleNodeTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_odd(self) -> None:
        head = ListNode.from_values([1, 2, 3, 4, 5])
        self.assertIs(self.solution().middle_node(head), head.next.next)

    def test_even(self) -> None:
        head = ListNode.from_values([1, 2, 3, 4])
        self.assertIs(self.solution().middle_node(head), head.next.next)

    def test_single(self) -> None:
        head = ListNode(1)
        self.assertIs(self.solution().middle_node(head), head)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

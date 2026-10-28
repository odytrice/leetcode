import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class ReorderListTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def verify(self, values: list[int], expected: list[int]) -> None:
        head = ListNode.from_values(values)
        self.solution().reorder_list(head)
        self.assertEqual(head.to_list(), expected)

    def test_odd(self) -> None:
        self.verify([1, 2, 3, 4, 5], [1, 5, 2, 4, 3])

    def test_even(self) -> None:
        self.verify([1, 2, 3, 4], [1, 4, 2, 3])

    def test_single(self) -> None:
        self.verify([1], [1])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

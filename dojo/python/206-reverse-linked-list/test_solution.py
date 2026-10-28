import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class ReverseListTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def to_list(self, head: ListNode | None) -> list[int]:
        return [] if head is None else head.to_list()

    def test_example(self) -> None:
        self.assertEqual(self.to_list(self.solution().reverse_list(ListNode.from_values([1, 2, 3]))), [3, 2, 1])

    def test_empty(self) -> None:
        self.assertIsNone(self.solution().reverse_list(None))

    def test_single(self) -> None:
        node = ListNode(7)
        self.assertIs(self.solution().reverse_list(node), node)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

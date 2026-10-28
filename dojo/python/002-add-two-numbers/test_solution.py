import sys
import unittest
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class AddTwoNumbersTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        result = self.solution().add_two_numbers(
            ListNode.from_values([2, 4, 3]), ListNode.from_values([5, 6, 4])
        )
        self.assertEqual(result.to_list(), [7, 0, 8])

    def test_carry_chain(self) -> None:
        result = self.solution().add_two_numbers(ListNode.from_values([9, 9, 9]), ListNode(1))
        self.assertEqual(result.to_list(), [0, 0, 0, 1])

    def test_zero(self) -> None:
        result = self.solution().add_two_numbers(ListNode(0), ListNode(0))
        self.assertEqual(result.to_list(), [0])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class TwoSumTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(sorted(self.solution().two_sum([2, 7, 11, 15], 9)), [0, 1])

    def test_duplicate_values(self) -> None:
        self.assertEqual(sorted(self.solution().two_sum([3, 3], 6)), [0, 1])

    def test_negative_values(self) -> None:
        self.assertEqual(sorted(self.solution().two_sum([4, -2, -3], -5)), [1, 2])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

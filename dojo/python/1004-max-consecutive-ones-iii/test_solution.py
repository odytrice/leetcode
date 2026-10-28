import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class LongestOnesTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().longest_ones([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2), 6)

    def test_no_flips(self) -> None:
        self.assertEqual(self.solution().longest_ones([1, 1, 0, 1], 0), 2)

    def test_all_zeros(self) -> None:
        self.assertEqual(self.solution().longest_ones([0, 0, 0], 2), 2)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class CheckSubarraySumTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertTrue(self.solution().check_subarray_sum([23, 2, 4, 6, 7], 6))

    def test_absent(self) -> None:
        self.assertFalse(self.solution().check_subarray_sum([23, 2, 6, 4, 7], 13))

    def test_too_short(self) -> None:
        self.assertFalse(self.solution().check_subarray_sum([6], 6))

    def test_zero_sum(self) -> None:
        self.assertTrue(self.solution().check_subarray_sum([0, 0], 7))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

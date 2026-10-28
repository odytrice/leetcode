import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class SubarraySumTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example_one(self) -> None:
        self.assertEqual(self.solution().subarray_sum([1, 1, 1], 2), 2)

    def test_example_two(self) -> None:
        self.assertEqual(self.solution().subarray_sum([1, 2, 3], 3), 2)

    def test_example_three(self) -> None:
        self.assertEqual(self.solution().subarray_sum([1, -1, 0], 0), 3)

    def test_single_match(self) -> None:
        self.assertEqual(self.solution().subarray_sum([3], 3), 1)

    def test_no_match(self) -> None:
        self.assertEqual(self.solution().subarray_sum([2, 4, 6], 5), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

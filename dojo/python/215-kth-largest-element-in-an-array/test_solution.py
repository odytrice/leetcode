import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class FindKthLargestTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().find_kth_largest([3, 2, 1, 5, 6, 4], 2), 5)

    def test_duplicates(self) -> None:
        self.assertEqual(self.solution().find_kth_largest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4), 4)

    def test_negative(self) -> None:
        self.assertEqual(self.solution().find_kth_largest([-1, -3, -2], 3), -3)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

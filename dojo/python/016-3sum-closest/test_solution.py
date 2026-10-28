import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class ThreeSumClosestTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().three_sum_closest([-1, 2, 1, -4], 1), 2)

    def test_zeros(self) -> None:
        self.assertEqual(self.solution().three_sum_closest([0, 0, 0], 1), 0)

    def test_exact(self) -> None:
        self.assertEqual(self.solution().three_sum_closest([1, 1, 1, 0], 3), 3)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class MinEatingSpeedTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().min_eating_speed([3, 6, 7, 11], 8), 4)

    def test_one_hour_per_pile(self) -> None:
        self.assertEqual(self.solution().min_eating_speed([30, 11, 23, 4, 20], 5), 30)

    def test_large_total_hours(self) -> None:
        self.assertEqual(self.solution().min_eating_speed([1_000_000_000] * 3, 1_000_000_000), 4)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

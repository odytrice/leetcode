import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class ShipWithinDaysTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().ship_within_days(list(range(1, 11)), 5), 15)

    def test_one_day(self) -> None:
        self.assertEqual(self.solution().ship_within_days([1, 2, 3], 1), 6)

    def test_one_per_day(self) -> None:
        self.assertEqual(self.solution().ship_within_days([1, 2, 3], 3), 3)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

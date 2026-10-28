import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class MinCostConnectPointsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            self.solution().min_cost_connect_points([[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]]),
            20,
        )

    def test_single(self) -> None:
        self.assertEqual(self.solution().min_cost_connect_points([[4, -2]]), 0)

    def test_negative_coordinates(self) -> None:
        self.assertEqual(
            self.solution().min_cost_connect_points([[3, 12], [-2, 5], [-4, 1]]),
            18,
        )

    def test_coordinate_limits(self) -> None:
        self.assertEqual(
            self.solution().min_cost_connect_points([[-1_000_000, -1_000_000], [1_000_000, 1_000_000]]),
            4_000_000,
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

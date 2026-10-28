import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class NetworkDelayTimeTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(
            self.solution().network_delay_time([[2, 1, 1], [2, 3, 1], [3, 4, 1]], 4, 2),
            2,
        )

    def test_directed_unreachable(self) -> None:
        self.assertEqual(self.solution().network_delay_time([[1, 2, 1]], 2, 2), -1)

    def test_improved_route(self) -> None:
        self.assertEqual(
            self.solution().network_delay_time([[1, 2, 10], [1, 3, 1], [3, 2, 1]], 3, 1),
            2,
        )

    def test_zero_weight(self) -> None:
        self.assertEqual(self.solution().network_delay_time([[1, 2, 0]], 2, 1), 0)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

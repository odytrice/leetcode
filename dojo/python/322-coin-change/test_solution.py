import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class CoinChangeTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().coin_change([1, 2, 5], 11), 3)

    def test_impossible(self) -> None:
        self.assertEqual(self.solution().coin_change([2], 3), -1)

    def test_zero(self) -> None:
        self.assertEqual(self.solution().coin_change([1], 0), 0)

    def test_greedy_fails(self) -> None:
        self.assertEqual(self.solution().coin_change([1, 3, 4], 6), 2)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

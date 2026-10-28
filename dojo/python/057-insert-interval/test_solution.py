import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class InsertTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_example(self) -> None:
        self.assertEqual(self.solution().insert([[1, 3], [6, 9]], [2, 5]), [[1, 5], [6, 9]])

    def test_bridge(self) -> None:
        self.assertEqual(
            self.solution().insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]),
            [[1, 2], [3, 10], [12, 16]],
        )

    def test_empty(self) -> None:
        self.assertEqual(self.solution().insert([], [5, 7]), [[5, 7]])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

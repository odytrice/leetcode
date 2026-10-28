import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class ShortestPathTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_diagonal(self) -> None:
        self.assertEqual(self.solution().shortest_path_binary_matrix([[0, 1], [1, 0]]), 2)

    def test_single(self) -> None:
        self.assertEqual(self.solution().shortest_path_binary_matrix([[0]]), 1)

    def test_blocked_start(self) -> None:
        self.assertEqual(self.solution().shortest_path_binary_matrix([[1, 0], [0, 0]]), -1)

    def test_disconnected(self) -> None:
        self.assertEqual(
            self.solution().shortest_path_binary_matrix([[0, 0, 0], [1, 1, 1], [0, 0, 0]]),
            -1,
        )

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

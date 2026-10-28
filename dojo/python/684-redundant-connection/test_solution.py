import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class FindRedundantConnectionTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_triangle(self) -> None:
        self.assertEqual(self.solution().find_redundant_connection([[1, 2], [1, 3], [2, 3]]), [2, 3])

    def test_cycle_before_final_edge(self) -> None:
        self.assertEqual(
            self.solution().find_redundant_connection([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]]),
            [1, 4],
        )

    def test_input_order_tie_break(self) -> None:
        self.assertEqual(self.solution().find_redundant_connection([[2, 3], [1, 3], [1, 2]]), [1, 2])

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

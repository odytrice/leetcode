import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


class NumIslandsTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def solve(self, rows: list[str]) -> int:
        return self.solution().num_islands([list(row) for row in rows])

    def test_example_one(self) -> None:
        self.assertEqual(self.solve(["11110", "11010", "11000", "00000"]), 1)

    def test_example_two(self) -> None:
        self.assertEqual(self.solve(["11000", "11000", "00100", "00011"]), 3)

    def test_diagonal_cells_are_separate(self) -> None:
        self.assertEqual(self.solve(["10", "01"]), 2)

    def test_all_water(self) -> None:
        self.assertEqual(self.solve(["000", "000"]), 0)

    def test_single_column(self) -> None:
        self.assertEqual(self.solve(["1", "1", "0", "1", "0", "1"]), 3)

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

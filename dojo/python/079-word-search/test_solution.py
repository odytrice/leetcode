import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def board() -> list[list[str]]:
    return [list(row) for row in ("ABCE", "SFCS", "ADEE")]


class ExistTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_found_and_restored(self) -> None:
        grid = board()
        self.assertTrue(self.solution().exist(grid, "ABCCED"))
        self.assertEqual(["".join(row) for row in grid], ["ABCE", "SFCS", "ADEE"])

    def test_no_cell_reuse(self) -> None:
        self.assertFalse(self.solution().exist(board(), "ABCB"))

    def test_backtracking(self) -> None:
        self.assertTrue(self.solution().exist(board(), "SEE"))

    def test_single(self) -> None:
        self.assertTrue(self.solution().exist([["a"]], "a"))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

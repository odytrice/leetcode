import sys
import unittest

from reference_solution import ReferenceSolution
from solution import Solution

USE_REFERENCE = "--reference" in sys.argv


def empty_board() -> list[list[str]]:
    return [["."] * 9 for _ in range(9)]


class ValidSudokuTests(unittest.TestCase):
    def solution(self) -> Solution:
        return ReferenceSolution() if USE_REFERENCE else Solution()

    def test_empty(self) -> None:
        self.assertTrue(self.solution().is_valid_sudoku(empty_board()))

    def test_row_duplicate(self) -> None:
        board = empty_board()
        board[0][0] = board[0][8] = "5"
        self.assertFalse(self.solution().is_valid_sudoku(board))

    def test_column_duplicate(self) -> None:
        board = empty_board()
        board[0][0] = board[8][0] = "5"
        self.assertFalse(self.solution().is_valid_sudoku(board))

    def test_box_duplicate(self) -> None:
        board = empty_board()
        board[0][0] = board[1][1] = "5"
        self.assertFalse(self.solution().is_valid_sudoku(board))

    def test_separate_units(self) -> None:
        board = empty_board()
        board[0][0] = board[4][4] = "5"
        self.assertTrue(self.solution().is_valid_sudoku(board))

    # Add your own cases here.


if __name__ == "__main__":
    suite = unittest.defaultTestLoader.loadTestsFromModule(sys.modules[__name__])
    result = unittest.TextTestRunner(verbosity=0).run(suite)
    total = result.testsRun
    failed = len(result.failures) + len(result.errors)
    print(f"\n{total - failed}/{total} passed.")
    sys.exit(0 if failed == 0 else 1)

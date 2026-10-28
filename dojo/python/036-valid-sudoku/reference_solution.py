class ReferenceSolution:
    # O(81) time. One set of (unit kind, unit index, digit) catches repeats.
    def is_valid_sudoku(self, board: list[list[str]]) -> bool:
        seen: set[tuple[int, int, str]] = set()
        for row in range(9):
            for column in range(9):
                digit = board[row][column]
                if digit == ".":
                    continue
                box = row // 3 * 3 + column // 3
                keys = [(0, row, digit), (1, column, digit), (2, box, digit)]
                if any(key in seen for key in keys):
                    return False
                seen.update(keys)
        return True

class ReferenceSolution:
    # O(rows * columns * 4^len(word)) time. Mark the current cell while searching.
    def exist(self, board: list[list[str]], word: str) -> bool:
        rows, columns = len(board), len(board[0])

        def search(row: int, column: int, index: int) -> bool:
            if not (0 <= row < rows and 0 <= column < columns) or board[row][column] != word[index]:
                return False
            if index == len(word) - 1:
                return True
            saved = board[row][column]
            board[row][column] = ""
            found = (
                search(row - 1, column, index + 1)
                or search(row + 1, column, index + 1)
                or search(row, column - 1, index + 1)
                or search(row, column + 1, index + 1)
            )
            board[row][column] = saved
            return found

        return any(search(row, column, 0) for row in range(rows) for column in range(columns))

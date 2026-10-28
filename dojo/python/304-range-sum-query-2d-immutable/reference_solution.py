from solution import NumMatrix


class ReferenceSolution(NumMatrix):
    # O(rows * cols) build, O(1) queries from a 2D prefix sum.
    def __init__(self, matrix: list[list[int]]) -> None:
        self.rows = len(matrix)
        self.cols = len(matrix[0])
        self.prefix = [[0] * (self.cols + 1) for _ in range(self.rows + 1)]
        for row in range(self.rows):
            for column in range(self.cols):
                self.prefix[row + 1][column + 1] = (
                    matrix[row][column]
                    + self.prefix[row][column + 1]
                    + self.prefix[row + 1][column]
                    - self.prefix[row][column]
                )

    def sum_region(self, row1: int, col1: int, row2: int, col2: int) -> int:
        prefix = self.prefix
        return (
            prefix[row2 + 1][col2 + 1]
            - prefix[row1][col2 + 1]
            - prefix[row2 + 1][col1]
            + prefix[row1][col1]
        )

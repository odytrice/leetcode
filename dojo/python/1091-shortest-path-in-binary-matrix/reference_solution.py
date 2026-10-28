class ReferenceSolution:
    # O(n^2) time. BFS over eight neighbours finds the shortest clear path.
    def shortest_path_binary_matrix(self, grid: list[list[int]]) -> int:
        size = len(grid)
        if grid[0][0] != 0 or grid[size - 1][size - 1] != 0:
            return -1
        queue = [(0, 0, 1)]
        grid[0][0] = 1
        while queue:
            row, column, length = queue.pop(0)
            if row == size - 1 and column == size - 1:
                return length
            for next_row in (row - 1, row, row + 1):
                for next_column in (column - 1, column, column + 1):
                    if (
                        0 <= next_row < size
                        and 0 <= next_column < size
                        and grid[next_row][next_column] == 0
                    ):
                        grid[next_row][next_column] = 1
                        queue.append((next_row, next_column, length + 1))
        return -1

class ReferenceSolution:
    # O(rows * columns) time. Flood each island and keep the largest area.
    def max_area_of_island(self, grid: list[list[int]]) -> int:
        rows, columns = len(grid), len(grid[0])
        best = 0
        for row in range(rows):
            for column in range(columns):
                if grid[row][column] == 0:
                    continue
                area = 0
                stack = [(row, column)]
                grid[row][column] = 0
                while stack:
                    current_row, current_column = stack.pop()
                    area += 1
                    for next_row, next_column in (
                        (current_row - 1, current_column),
                        (current_row + 1, current_column),
                        (current_row, current_column - 1),
                        (current_row, current_column + 1),
                    ):
                        if 0 <= next_row < rows and 0 <= next_column < columns and grid[next_row][next_column] == 1:
                            grid[next_row][next_column] = 0
                            stack.append((next_row, next_column))
                best = max(best, area)
        return best

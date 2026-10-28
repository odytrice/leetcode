class ReferenceSolution:
    # O(rows * columns) time. Multi-source BFS spreads rot one minute per layer.
    def oranges_rotting(self, grid: list[list[int]]) -> int:
        rows, columns = len(grid), len(grid[0])
        fresh = 0
        queue: list[tuple[int, int]] = []
        for row in range(rows):
            for column in range(columns):
                if grid[row][column] == 1:
                    fresh += 1
                elif grid[row][column] == 2:
                    queue.append((row, column))

        minutes = 0
        while fresh > 0 and queue:
            minutes += 1
            next_queue: list[tuple[int, int]] = []
            for row, column in queue:
                for next_row, next_column in (
                    (row - 1, column),
                    (row + 1, column),
                    (row, column - 1),
                    (row, column + 1),
                ):
                    if 0 <= next_row < rows and 0 <= next_column < columns and grid[next_row][next_column] == 1:
                        grid[next_row][next_column] = 2
                        fresh -= 1
                        next_queue.append((next_row, next_column))
            queue = next_queue

        return minutes if fresh == 0 else -1

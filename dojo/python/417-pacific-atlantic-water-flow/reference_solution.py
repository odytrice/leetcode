class ReferenceSolution:
    # O(rows * columns) time. Flood backwards from each ocean and intersect.
    def pacific_atlantic(self, heights: list[list[int]]) -> list[list[int]]:
        rows, columns = len(heights), len(heights[0])

        def reach(pacific: bool) -> set[tuple[int, int]]:
            seen: set[tuple[int, int]] = set()
            stack: list[tuple[int, int]] = []
            for row in range(rows):
                stack.append((row, 0 if pacific else columns - 1))
            for column in range(columns):
                stack.append((0 if pacific else rows - 1, column))
            seen.update(stack)
            while stack:
                row, column = stack.pop()
                for next_row, next_column in (
                    (row - 1, column),
                    (row + 1, column),
                    (row, column - 1),
                    (row, column + 1),
                ):
                    if (
                        0 <= next_row < rows
                        and 0 <= next_column < columns
                        and (next_row, next_column) not in seen
                        and heights[next_row][next_column] >= heights[row][column]
                    ):
                        seen.add((next_row, next_column))
                        stack.append((next_row, next_column))
            return seen

        return [list(cell) for cell in sorted(reach(True) & reach(False))]

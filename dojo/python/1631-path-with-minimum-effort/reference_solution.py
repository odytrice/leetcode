import heapq


class ReferenceSolution:
    # O(rows * columns log cells) time. Dijkstra on the maximum step along the path.
    def minimum_effort_path(self, heights: list[list[int]]) -> int:
        rows, columns = len(heights), len(heights[0])
        effort = [[float("inf")] * columns for _ in range(rows)]
        effort[0][0] = 0
        heap = [(0, 0, 0)]
        while heap:
            cost, row, column = heapq.heappop(heap)
            if cost != effort[row][column]:
                continue
            if row == rows - 1 and column == columns - 1:
                return cost
            for next_row, next_column in (
                (row - 1, column),
                (row + 1, column),
                (row, column - 1),
                (row, column + 1),
            ):
                if 0 <= next_row < rows and 0 <= next_column < columns:
                    step = max(cost, abs(heights[next_row][next_column] - heights[row][column]))
                    if step < effort[next_row][next_column]:
                        effort[next_row][next_column] = step
                        heapq.heappush(heap, (step, next_row, next_column))
        return 0

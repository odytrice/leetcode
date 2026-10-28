import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(rows * columns) time. Multi-source BFS spreads rot one minute per layer. */
class ReferenceSolution extends Solution {
    @Override
    public int orangesRotting(int[][] grid) {
        int rows = grid.length;
        int columns = grid[0].length;
        int fresh = 0;
        Deque<int[]> queue = new ArrayDeque<>();
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {
                if (grid[row][column] == 1) {
                    fresh++;
                } else if (grid[row][column] == 2) {
                    queue.add(new int[] {row, column});
                }
            }
        }

        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        int minutes = 0;
        while (fresh > 0 && !queue.isEmpty()) {
            minutes++;
            List<int[]> nextQueue = new ArrayList<>();
            for (int[] cell : queue) {
                for (int step = 0; step < 4; step++) {
                    int nextRow = cell[0] + rowStep[step];
                    int nextColumn = cell[1] + columnStep[step];
                    if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns
                            || grid[nextRow][nextColumn] != 1) {
                        continue;
                    }
                    grid[nextRow][nextColumn] = 2;
                    fresh--;
                    nextQueue.add(new int[] {nextRow, nextColumn});
                }
            }
            queue = new ArrayDeque<>(nextQueue);
        }

        return fresh == 0 ? minutes : -1;
    }
}

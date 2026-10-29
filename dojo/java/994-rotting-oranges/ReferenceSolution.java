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
        // Count the fresh oranges and queue every rotten one, since they all spread at once.
        int fresh = 0;
        Deque<int[]> queue = new ArrayDeque<>();
        for (int row = 0; row < rows; row += 1) {
            for (int column = 0; column < columns; column += 1) {
                if (grid[row][column] == 1) {
                    fresh += 1;
                } else if (grid[row][column] == 2) {
                    queue.add(new int[] {row, column});
                }
            }
        }

        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        int minutes = 0;
        // Stop when nothing fresh is left, or when the rot can spread no further.
        while (fresh > 0 && !queue.isEmpty()) {
            // Each pass is one minute: the current queue is this minute's rotten layer.
            minutes += 1;
            List<int[]> nextQueue = new ArrayList<>();
            for (int[] cell : queue) {
                for (int step = 0; step < 4; step += 1) {
                    int nextRow = cell[0] + rowStep[step];
                    int nextColumn = cell[1] + columnStep[step];
                    if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns
                            || grid[nextRow][nextColumn] != 1) {
                        continue;
                    }
                    // Rot it now so another neighbour does not queue the same orange again.
                    grid[nextRow][nextColumn] = 2;
                    fresh -= 1;
                    nextQueue.add(new int[] {nextRow, nextColumn});
                }
            }
            queue = new ArrayDeque<>(nextQueue);
        }

        // Fresh oranges left over were walled off and can never rot.
        return fresh == 0 ? minutes : -1;
    }
}

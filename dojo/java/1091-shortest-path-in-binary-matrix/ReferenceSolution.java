import java.util.ArrayDeque;
import java.util.Deque;

/** O(n^2) time. BFS over eight neighbours finds the shortest clear path. */
class ReferenceSolution extends Solution {
    @Override
    public int shortestPathBinaryMatrix(int[][] grid) {
        int size = grid.length;
        // A blocked start or end means no path can exist.
        if (grid[0][0] != 0 || grid[size - 1][size - 1] != 0) {
            return -1;
        }
        // Each queue entry is {row, column, path length so far}, counting cells, not moves.
        Deque<int[]> queue = new ArrayDeque<>();
        queue.add(new int[] {0, 0, 1});
        // Mark a cell visited when it is queued so no other path queues it twice.
        grid[0][0] = 1;
        while (!queue.isEmpty()) {
            int[] cell = queue.poll();
            int row = cell[0];
            int column = cell[1];
            int length = cell[2];
            // BFS reaches cells in order of distance, so the first arrival is the shortest.
            if (row == size - 1 && column == size - 1) {
                return length;
            }
            // Try all eight directions; the (0, 0) step lands on a visited cell and is skipped.
            for (int rowStep = -1; rowStep <= 1; rowStep += 1) {
                for (int columnStep = -1; columnStep <= 1; columnStep += 1) {
                    int nextRow = row + rowStep;
                    int nextColumn = column + columnStep;
                    if (nextRow < 0 || nextColumn < 0 || nextRow >= size || nextColumn >= size
                            || grid[nextRow][nextColumn] != 0) {
                        continue;
                    }
                    grid[nextRow][nextColumn] = 1;
                    queue.add(new int[] {nextRow, nextColumn, length + 1});
                }
            }
        }
        // The queue ran dry without reaching the corner.
        return -1;
    }
}

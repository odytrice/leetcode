import java.util.ArrayDeque;
import java.util.Deque;

/** O(n^2) time. BFS over eight neighbours finds the shortest clear path. */
class ReferenceSolution extends Solution {
    @Override
    public int shortestPathBinaryMatrix(int[][] grid) {
        int size = grid.length;
        if (grid[0][0] != 0 || grid[size - 1][size - 1] != 0) {
            return -1;
        }
        Deque<int[]> queue = new ArrayDeque<>();
        queue.add(new int[] {0, 0, 1});
        grid[0][0] = 1;
        while (!queue.isEmpty()) {
            int[] cell = queue.poll();
            int row = cell[0];
            int column = cell[1];
            int length = cell[2];
            if (row == size - 1 && column == size - 1) {
                return length;
            }
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
        return -1;
    }
}

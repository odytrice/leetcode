import java.util.ArrayDeque;
import java.util.Deque;

/** O(rows * columns) time. Floods each island and keeps the largest area. */
class ReferenceSolution extends Solution {
    @Override
    public int maxAreaOfIsland(int[][] grid) {
        int rows = grid.length;
        int columns = grid[0].length;
        // Offsets for up, down, left and right.
        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        int best = 0;
        for (int row = 0; row < rows; row += 1) {
            for (int column = 0; column < columns; column += 1) {
                if (grid[row][column] == 0) {
                    continue;
                }
                // Unvisited land: flood the whole island and count its cells.
                int area = 0;
                Deque<int[]> stack = new ArrayDeque<>();
                stack.push(new int[] {row, column});
                // Sink a cell when it is pushed so it is counted exactly once.
                grid[row][column] = 0;
                while (!stack.isEmpty()) {
                    int[] cell = stack.pop();
                    area += 1;
                    for (int step = 0; step < 4; step += 1) {
                        int nextRow = cell[0] + rowStep[step];
                        int nextColumn = cell[1] + columnStep[step];
                        if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns
                                || grid[nextRow][nextColumn] == 0) {
                            continue;
                        }
                        grid[nextRow][nextColumn] = 0;
                        stack.push(new int[] {nextRow, nextColumn});
                    }
                }
                best = Math.max(best, area);
            }
        }
        return best;
    }
}

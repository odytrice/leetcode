import java.util.ArrayDeque;
import java.util.Deque;

/** O(rows * columns) time. Floods each island and keeps the largest area. */
class ReferenceSolution extends Solution {
    @Override
    public int maxAreaOfIsland(int[][] grid) {
        int rows = grid.length;
        int columns = grid[0].length;
        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        int best = 0;
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {
                if (grid[row][column] == 0) {
                    continue;
                }
                int area = 0;
                Deque<int[]> stack = new ArrayDeque<>();
                stack.push(new int[] {row, column});
                grid[row][column] = 0;
                while (!stack.isEmpty()) {
                    int[] cell = stack.pop();
                    area++;
                    for (int step = 0; step < 4; step++) {
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

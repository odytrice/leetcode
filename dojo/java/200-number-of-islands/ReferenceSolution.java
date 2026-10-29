import java.util.ArrayDeque;
import java.util.Deque;

/** O(rows * columns) time. Marks visited land as water while flooding. */
class ReferenceSolution extends Solution {
    @Override
    public int numIslands(char[][] grid) {
        int rows = grid.length;
        int columns = grid[0].length;
        int count = 0;
        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        for (int row = 0; row < rows; row += 1) {
            for (int column = 0; column < columns; column += 1) {
                if (grid[row][column] != '1') {
                    continue;
                }
                count += 1;
                Deque<int[]> stack = new ArrayDeque<>();
                stack.push(new int[] {row, column});
                grid[row][column] = '0';
                while (!stack.isEmpty()) {
                    int[] cell = stack.pop();
                    for (int step = 0; step < 4; step += 1) {
                        int nextRow = cell[0] + rowStep[step];
                        int nextColumn = cell[1] + columnStep[step];
                        if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns
                                || grid[nextRow][nextColumn] != '1') {
                            continue;
                        }
                        grid[nextRow][nextColumn] = '0';
                        stack.push(new int[] {nextRow, nextColumn});
                    }
                }
            }
        }
        return count;
    }
}

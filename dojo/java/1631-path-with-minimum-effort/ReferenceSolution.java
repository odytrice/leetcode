import java.util.Arrays;
import java.util.PriorityQueue;

/** O(rows * columns log cells) time. Dijkstra on the maximum step along the path. */
class ReferenceSolution extends Solution {
    @Override
    public int minimumEffortPath(int[][] heights) {
        int rows = heights.length;
        int columns = heights[0].length;
        int[][] effort = new int[rows][columns];
        for (int[] row : effort) {
            Arrays.fill(row, Integer.MAX_VALUE);
        }
        effort[0][0] = 0;
        PriorityQueue<int[]> queue = new PriorityQueue<>((a, b) -> Integer.compare(a[0], b[0]));
        queue.add(new int[] {0, 0, 0});
        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        while (!queue.isEmpty()) {
            int[] cell = queue.poll();
            int cost = cell[0];
            int row = cell[1];
            int column = cell[2];
            if (cost != effort[row][column]) {
                continue;
            }
            if (row == rows - 1 && column == columns - 1) {
                return cost;
            }
            for (int step = 0; step < 4; step += 1) {
                int nextRow = row + rowStep[step];
                int nextColumn = column + columnStep[step];
                if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns) {
                    continue;
                }
                int nextCost = Math.max(cost, Math.abs(heights[nextRow][nextColumn] - heights[row][column]));
                if (nextCost < effort[nextRow][nextColumn]) {
                    effort[nextRow][nextColumn] = nextCost;
                    queue.add(new int[] {nextCost, nextRow, nextColumn});
                }
            }
        }
        return 0;
    }
}

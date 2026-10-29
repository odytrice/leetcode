import java.util.Arrays;
import java.util.PriorityQueue;

/** O(rows * columns log cells) time. Dijkstra on the maximum step along the path. */
class ReferenceSolution extends Solution {
    @Override
    public int minimumEffortPath(int[][] heights) {
        int rows = heights.length;
        int columns = heights[0].length;
        // effort[r][c] is the smallest known "largest step" on any path to that cell.
        int[][] effort = new int[rows][columns];
        for (int[] row : effort) {
            Arrays.fill(row, Integer.MAX_VALUE);
        }
        effort[0][0] = 0;
        // Queue entries are {effort, row, column}, smallest effort first.
        PriorityQueue<int[]> queue = new PriorityQueue<>((a, b) -> Integer.compare(a[0], b[0]));
        queue.add(new int[] {0, 0, 0});
        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        while (!queue.isEmpty()) {
            int[] cell = queue.poll();
            int cost = cell[0];
            int row = cell[1];
            int column = cell[2];
            // A better path to this cell was found after this entry was queued, so skip it.
            if (cost != effort[row][column]) {
                continue;
            }
            // The first time the corner is popped, its effort is final and minimal.
            if (row == rows - 1 && column == columns - 1) {
                return cost;
            }
            for (int step = 0; step < 4; step += 1) {
                int nextRow = row + rowStep[step];
                int nextColumn = column + columnStep[step];
                if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns) {
                    continue;
                }
                // A path's effort is its biggest single climb, not the sum of climbs.
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

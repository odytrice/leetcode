import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

/** O(rows * columns) time. Floods backwards from each ocean and intersects. */
class ReferenceSolution extends Solution {
    private int rows;
    private int columns;
    private int[][] heights;

    @Override
    public List<List<Integer>> pacificAtlantic(int[][] heights) {
        this.heights = heights;
        rows = heights.length;
        columns = heights[0].length;
        Set<Integer> pacific = reach(true);
        Set<Integer> atlantic = reach(false);
        // A cell that can drain to both oceans appears in both sets.
        List<List<Integer>> result = new ArrayList<>();
        for (int row = 0; row < rows; row += 1) {
            for (int column = 0; column < columns; column += 1) {
                int key = row * columns + column;
                if (pacific.contains(key) && atlantic.contains(key)) {
                    result.add(List.of(row, column));
                }
            }
        }
        return result;
    }

    // Returns the cells (as row * columns + column) whose water can reach the chosen ocean.
    private Set<Integer> reach(boolean pacific) {
        Set<Integer> seen = new HashSet<>();
        Deque<int[]> stack = new ArrayDeque<>();
        // Start from the edges touching this ocean: left and top for Pacific, right and bottom for Atlantic.
        for (int row = 0; row < rows; row += 1) {
            stack.push(new int[] {row, pacific ? 0 : columns - 1});
        }
        for (int column = 0; column < columns; column += 1) {
            stack.push(new int[] {pacific ? 0 : rows - 1, column});
        }
        for (int[] cell : stack) {
            seen.add(cell[0] * columns + cell[1]);
        }
        int[] rowStep = {-1, 1, 0, 0};
        int[] columnStep = {0, 0, -1, 1};
        while (!stack.isEmpty()) {
            int[] cell = stack.pop();
            for (int step = 0; step < 4; step += 1) {
                int nextRow = cell[0] + rowStep[step];
                int nextColumn = cell[1] + columnStep[step];
                if (nextRow < 0 || nextColumn < 0 || nextRow >= rows || nextColumn >= columns) {
                    continue;
                }
                int key = nextRow * columns + nextColumn;
                // Walking uphill in reverse means water could flow downhill from that neighbour to here.
                if (!seen.contains(key) && heights[nextRow][nextColumn] >= heights[cell[0]][cell[1]]) {
                    seen.add(key);
                    stack.push(new int[] {nextRow, nextColumn});
                }
            }
        }
        return seen;
    }
}

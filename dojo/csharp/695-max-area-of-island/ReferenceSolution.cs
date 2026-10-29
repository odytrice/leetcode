public class ReferenceSolution : Solution
{
    // O(rows * cols) time. Sink each island with a DFS and count its cells.
    public override int MaxAreaOfIsland(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int best = 0;
        int[] dr = [-1, 1, 0, 0];
        int[] dc = [0, 0, -1, 1];
        for (int r = 0; r < rows; r += 1)
        {
            for (int c = 0; c < cols; c += 1)
            {
                // Skip water and land already counted in an earlier island.
                if (grid[r][c] == 0)
                {
                    continue;
                }
                var stack = new Stack<(int R, int C)>();
                stack.Push((r, c));
                // Sink cells as they are pushed so each one is counted once.
                grid[r][c] = 0;
                int area = 0;
                while (stack.TryPop(out var cell))
                {
                    // Every popped cell is one more square of this island.
                    area += 1;
                    for (int d = 0; d < 4; d += 1)
                    {
                        int nr = cell.R + dr[d];
                        int nc = cell.C + dc[d];
                        if (nr < 0 || nc < 0 || nr >= rows || nc >= cols || grid[nr][nc] == 0)
                        {
                            continue;
                        }
                        grid[nr][nc] = 0;
                        stack.Push((nr, nc));
                    }
                }
                best = Math.Max(best, area);
            }
        }
        return best;
    }
}

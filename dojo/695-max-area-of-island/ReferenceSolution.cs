public class ReferenceSolution : Solution
{
    public override int MaxAreaOfIsland(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length, best = 0;
        int[] dr = [-1, 1, 0, 0], dc = [0, 0, -1, 1];
        for (int r = 0; r < rows; r++) for (int c = 0; c < cols; c++)
        {
            if (grid[r][c] == 0) continue;
            var stack = new Stack<(int R, int C)>(); stack.Push((r, c)); grid[r][c] = 0; int area = 0;
            while (stack.TryPop(out var cell))
            {
                area++;
                for (int d = 0; d < 4; d++)
                {
                    int nr = cell.R + dr[d], nc = cell.C + dc[d];
                    if (nr < 0 || nc < 0 || nr >= rows || nc >= cols || grid[nr][nc] == 0) continue;
                    grid[nr][nc] = 0; stack.Push((nr, nc));
                }
            }
            best = Math.Max(best, area);
        }
        return best;
    }
}

public class ReferenceSolution
{
    // O(rows * columns) time and space. Marks visited land as water.
    public int NumIslands(char[][] grid)
    {
        int count = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        int[] dr = [-1, 1, 0, 0];
        int[] dc = [0, 0, -1, 1];
        for (int r = 0; r < rows; r += 1)
        {
            for (int c = 0; c < cols; c += 1)
            {
                if (grid[r][c] != '1')
                {
                    continue;
                }
                count += 1;

                // Sink the whole island with an iterative DFS.
                var stack = new Stack<(int R, int C)>();
                stack.Push((r, c));
                grid[r][c] = '0';
                while (stack.TryPop(out var cell))
                {
                    for (int d = 0; d < 4; d += 1)
                    {
                        int nr = cell.R + dr[d];
                        int nc = cell.C + dc[d];
                        if (nr < 0 || nc < 0 || nr >= rows || nc >= cols || grid[nr][nc] != '1')
                        {
                            continue;
                        }
                        grid[nr][nc] = '0';
                        stack.Push((nr, nc));
                    }
                }
            }
        }
        return count;
    }
}

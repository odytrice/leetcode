public class ReferenceSolution
{
    // O(rows * columns) time and space. Marks visited land as water.
    public int NumIslands(char[][] grid)
    {
        int count = 0, rows = grid.Length, cols = grid[0].Length;
        int[] dr = [-1, 1, 0, 0], dc = [0, 0, -1, 1];
        for (int r = 0; r < rows; r++)
        for (int c = 0; c < cols; c++)
        {
            if (grid[r][c] != '1') continue;
            count++;
            var stack = new Stack<(int R, int C)>();
            stack.Push((r, c)); grid[r][c] = '0';
            while (stack.TryPop(out var cell))
            for (int d = 0; d < 4; d++)
            {
                int nr = cell.R + dr[d], nc = cell.C + dc[d];
                if (nr < 0 || nc < 0 || nr >= rows || nc >= cols || grid[nr][nc] != '1') continue;
                grid[nr][nc] = '0'; stack.Push((nr, nc));
            }
        }
        return count;
    }
}

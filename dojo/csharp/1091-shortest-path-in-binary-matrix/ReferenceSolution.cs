public class ReferenceSolution : Solution
{
    public override int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length;
        if (grid[0][0] != 0 || grid[n - 1][n - 1] != 0) return -1;
        var queue = new Queue<(int R, int C, int Length)>(); queue.Enqueue((0, 0, 1)); grid[0][0] = 1;
        while (queue.TryDequeue(out var cell))
        {
            if (cell.R == n - 1 && cell.C == n - 1) return cell.Length;
            for (int dr = -1; dr <= 1; dr++) for (int dc = -1; dc <= 1; dc++)
            {
                int r = cell.R + dr, c = cell.C + dc;
                if (r < 0 || c < 0 || r >= n || c >= n || grid[r][c] != 0) continue;
                grid[r][c] = 1; queue.Enqueue((r, c, cell.Length + 1));
            }
        }
        return -1;
    }
}

public class ReferenceSolution : Solution
{
    public override int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length, fresh = 0, minutes = 0;
        var queue = new Queue<(int R, int C)>();
        for (int r = 0; r < rows; r++) for (int c = 0; c < cols; c++)
            if (grid[r][c] == 1) fresh++; else if (grid[r][c] == 2) queue.Enqueue((r, c));
        int[] dr = [-1, 1, 0, 0], dc = [0, 0, -1, 1];
        while (fresh > 0 && queue.Count > 0)
        {
            int count = queue.Count; minutes++;
            while (count-- > 0)
            {
                var cell = queue.Dequeue();
                for (int d = 0; d < 4; d++)
                {
                    int r = cell.R + dr[d], c = cell.C + dc[d];
                    if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] != 1) continue;
                    grid[r][c] = 2; fresh--; queue.Enqueue((r, c));
                }
            }
        }
        return fresh == 0 ? minutes : -1;
    }
}

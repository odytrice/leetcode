public class ReferenceSolution : Solution
{
    // O(rows * cols) time. Multi-source BFS from every rotten orange, one minute per level.
    public override int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int fresh = 0;
        int minutes = 0;
        var queue = new Queue<(int R, int C)>();
        for (int r = 0; r < rows; r += 1)
        {
            for (int c = 0; c < cols; c += 1)
            {
                if (grid[r][c] == 1)
                {
                    fresh += 1;
                }
                else if (grid[r][c] == 2)
                {
                    queue.Enqueue((r, c));
                }
            }
        }
        int[] dr = [-1, 1, 0, 0];
        int[] dc = [0, 0, -1, 1];
        while (fresh > 0 && queue.Count > 0)
        {
            int count = queue.Count;
            minutes += 1;
            for (int i = 0; i < count; i += 1)
            {
                var cell = queue.Dequeue();
                for (int d = 0; d < 4; d += 1)
                {
                    int r = cell.R + dr[d];
                    int c = cell.C + dc[d];
                    if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] != 1)
                    {
                        continue;
                    }
                    grid[r][c] = 2;
                    fresh -= 1;
                    queue.Enqueue((r, c));
                }
            }
        }
        return fresh == 0 ? minutes : -1;
    }
}

public class ReferenceSolution : Solution
{
    // O(n^2) time. BFS over the eight neighbours finds the shortest clear path.
    public override int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length;
        // A blocked start or end means no path exists.
        if (grid[0][0] != 0 || grid[n - 1][n - 1] != 0)
        {
            return -1;
        }
        var queue = new Queue<(int R, int C, int Length)>();
        queue.Enqueue((0, 0, 1));
        // Mark cells as visited when they join the queue.
        grid[0][0] = 1;
        while (queue.TryDequeue(out var cell))
        {
            // BFS reaches each cell first along a shortest path, so the first arrival wins.
            if (cell.R == n - 1 && cell.C == n - 1)
            {
                return cell.Length;
            }
            // Try all eight directions; (0, 0) is the cell itself, which is already marked.
            for (int dr = -1; dr <= 1; dr += 1)
            {
                for (int dc = -1; dc <= 1; dc += 1)
                {
                    int r = cell.R + dr;
                    int c = cell.C + dc;
                    if (r < 0 || c < 0 || r >= n || c >= n || grid[r][c] != 0)
                    {
                        continue;
                    }
                    // Marking now stops another cell from queueing it a second time.
                    grid[r][c] = 1;
                    queue.Enqueue((r, c, cell.Length + 1));
                }
            }
        }
        return -1;
    }
}

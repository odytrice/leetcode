public class ReferenceSolution : Solution
{
    // O(rows * cols * log) time. Dijkstra where a path costs its largest single step.
    public override int MinimumEffortPath(int[][] heights)
    {
        int rows = heights.Length;
        int cols = heights[0].Length;
        // dist[r, c] is the smallest effort found so far to reach that cell.
        var dist = new int[rows, cols];
        for (int r = 0; r < rows; r += 1)
        {
            for (int c = 0; c < cols; c += 1)
            {
                dist[r, c] = int.MaxValue;
            }
        }
        dist[0, 0] = 0;
        var queue = new PriorityQueue<(int R, int C), int>();
        queue.Enqueue((0, 0), 0);
        int[] dr = [-1, 1, 0, 0];
        int[] dc = [0, 0, -1, 1];
        while (queue.TryDequeue(out var cell, out int effort))
        {
            // Skip stale queue entries.
            if (effort != dist[cell.R, cell.C])
            {
                continue;
            }
            // The first time the target is popped, its effort is final.
            if (cell.R == rows - 1 && cell.C == cols - 1)
            {
                return effort;
            }
            for (int d = 0; d < 4; d += 1)
            {
                int r = cell.R + dr[d];
                int c = cell.C + dc[d];
                if (r < 0 || c < 0 || r >= rows || c >= cols)
                {
                    continue;
                }
                // A path's effort is its largest step, so take the max instead of a sum.
                int next = Math.Max(effort, Math.Abs(heights[r][c] - heights[cell.R][cell.C]));
                // Only queue a neighbor when this path improves on its best so far.
                if (next < dist[r, c])
                {
                    dist[r, c] = next;
                    queue.Enqueue((r, c), next);
                }
            }
        }
        // Unreachable: the grid is connected, so the corner is always popped.
        return 0;
    }
}

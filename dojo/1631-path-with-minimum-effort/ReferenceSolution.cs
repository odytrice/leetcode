public class ReferenceSolution : Solution
{
    public override int MinimumEffortPath(int[][] heights)
    {
        int rows = heights.Length, cols = heights[0].Length; var dist = new int[rows, cols];
        for (int r = 0; r < rows; r++) for (int c = 0; c < cols; c++) dist[r, c] = int.MaxValue;
        dist[0, 0] = 0; var queue = new PriorityQueue<(int R, int C), int>(); queue.Enqueue((0, 0), 0);
        int[] dr = [-1, 1, 0, 0], dc = [0, 0, -1, 1];
        while (queue.TryDequeue(out var cell, out int effort))
        {
            if (effort != dist[cell.R, cell.C]) continue;
            if (cell.R == rows - 1 && cell.C == cols - 1) return effort;
            for (int d = 0; d < 4; d++)
            {
                int r = cell.R + dr[d], c = cell.C + dc[d];
                if (r < 0 || c < 0 || r >= rows || c >= cols) continue;
                int next = Math.Max(effort, Math.Abs(heights[r][c] - heights[cell.R][cell.C]));
                if (next < dist[r, c]) { dist[r, c] = next; queue.Enqueue((r, c), next); }
            }
        }
        return 0;
    }
}

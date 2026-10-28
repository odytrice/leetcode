public class ReferenceSolution : Solution
{
    public override IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        int rows = heights.Length, cols = heights[0].Length;
        bool[,] Reach(bool pacific)
        {
            var seen = new bool[rows, cols]; var queue = new Queue<(int R, int C)>();
            void Add(int r, int c) { if (!seen[r, c]) { seen[r, c] = true; queue.Enqueue((r, c)); } }
            for (int r = 0; r < rows; r++) Add(r, pacific ? 0 : cols - 1);
            for (int c = 0; c < cols; c++) Add(pacific ? 0 : rows - 1, c);
            int[] dr = [-1, 1, 0, 0], dc = [0, 0, -1, 1];
            while (queue.TryDequeue(out var cell))
            for (int d = 0; d < 4; d++)
            {
                int r = cell.R + dr[d], c = cell.C + dc[d];
                if (r >= 0 && c >= 0 && r < rows && c < cols && !seen[r, c] && heights[r][c] >= heights[cell.R][cell.C]) Add(r, c);
            }
            return seen;
        }
        var p = Reach(true); var a = Reach(false); var result = new List<IList<int>>();
        for (int r = 0; r < rows; r++) for (int c = 0; c < cols; c++) if (p[r, c] && a[r, c]) result.Add(new[] { r, c });
        return result;
    }
}

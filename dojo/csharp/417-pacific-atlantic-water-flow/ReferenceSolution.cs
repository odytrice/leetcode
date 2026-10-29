public class ReferenceSolution : Solution
{
    // O(rows * cols) time. Flow uphill from each ocean's border; answer the cells both reach.
    public override IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        int rows = heights.Length;
        int cols = heights[0].Length;

        // Returns the cells whose water can drain into the chosen ocean.
        bool[,] Reach(bool pacific)
        {
            var seen = new bool[rows, cols];
            var queue = new Queue<(int R, int C)>();

            // Marks a cell when it is queued so it never enters the queue twice.
            void Add(int r, int c)
            {
                if (!seen[r, c])
                {
                    seen[r, c] = true;
                    queue.Enqueue((r, c));
                }
            }

            // The Pacific touches the top and left edges; the Atlantic the bottom and right.
            for (int r = 0; r < rows; r += 1)
            {
                Add(r, pacific ? 0 : cols - 1);
            }
            for (int c = 0; c < cols; c += 1)
            {
                Add(pacific ? 0 : rows - 1, c);
            }

            int[] dr = [-1, 1, 0, 0];
            int[] dc = [0, 0, -1, 1];
            while (queue.TryDequeue(out var cell))
            {
                for (int d = 0; d < 4; d += 1)
                {
                    int r = cell.R + dr[d];
                    int c = cell.C + dc[d];
                    // An equal or higher neighbor can drain down into this cell, so it reaches the ocean too.
                    if (r >= 0 && c >= 0 && r < rows && c < cols && !seen[r, c] && heights[r][c] >= heights[cell.R][cell.C])
                    {
                        Add(r, c);
                    }
                }
            }
            return seen;
        }

        var p = Reach(true);
        var a = Reach(false);
        var result = new List<IList<int>>();
        for (int r = 0; r < rows; r += 1)
        {
            for (int c = 0; c < cols; c += 1)
            {
                // Keep the cells that drain into both oceans.
                if (p[r, c] && a[r, c])
                {
                    result.Add(new[] { r, c });
                }
            }
        }
        return result;
    }
}

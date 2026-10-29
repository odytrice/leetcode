public class ReferenceSolution : NumMatrix
{
    // O(rows * cols) setup, O(1) per query. prefix[r, c] sums the rectangle above and left of (r, c).
    private readonly long[,] prefix;

    public ReferenceSolution(int[][] matrix) : base(matrix)
    {
        prefix = new long[matrix.Length + 1, matrix[0].Length + 1];
        for (int r = 0; r < matrix.Length; r += 1)
        {
            for (int c = 0; c < matrix[0].Length; c += 1)
            {
                prefix[r + 1, c + 1] = matrix[r][c] + prefix[r, c + 1] + prefix[r + 1, c] - prefix[r, c];
            }
        }
    }

    public override int SumRegion(int row1, int col1, int row2, int col2)
    {
        // Inclusion-exclusion: subtract the strips above and to the left, add back their overlap.
        return (int)(prefix[row2 + 1, col2 + 1] - prefix[row1, col2 + 1] - prefix[row2 + 1, col1] + prefix[row1, col1]);
    }
}

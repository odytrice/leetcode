public class ReferenceSolution : NumMatrix
{
    private readonly long[,] prefix;
    public ReferenceSolution(int[][] matrix) : base(matrix)
    {
        prefix = new long[matrix.Length + 1, matrix[0].Length + 1];
        for (int r = 0; r < matrix.Length; r++)
        for (int c = 0; c < matrix[0].Length; c++)
            prefix[r + 1, c + 1] = matrix[r][c] + prefix[r, c + 1] + prefix[r + 1, c] - prefix[r, c];
    }
    public override int SumRegion(int row1, int col1, int row2, int col2) =>
        (int)(prefix[row2 + 1, col2 + 1] - prefix[row1, col2 + 1] - prefix[row2 + 1, col1] + prefix[row1, col1]);
}

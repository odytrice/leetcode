/** O(rows * cols) build, O(1) queries from a 2D prefix sum. */
class ReferenceSolution extends NumMatrix {
    private final long[][] prefix;

    ReferenceSolution(int[][] matrix) {
        super(matrix);
        int rows = matrix.length;
        int cols = matrix[0].length;
        prefix = new long[rows + 1][cols + 1];
        for (int row = 0; row < rows; row += 1) {
            for (int column = 0; column < cols; column += 1) {
                prefix[row + 1][column + 1] = matrix[row][column]
                        + prefix[row][column + 1]
                        + prefix[row + 1][column]
                        - prefix[row][column];
            }
        }
    }

    @Override
    public int sumRegion(int row1, int col1, int row2, int col2) {
        return (int) (prefix[row2 + 1][col2 + 1]
                - prefix[row1][col2 + 1]
                - prefix[row2 + 1][col1]
                + prefix[row1][col1]);
    }
}

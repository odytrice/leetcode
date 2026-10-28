module ReferenceSolution

open Solution

// O(rows * cols) build, O(1) queries from a 2D prefix sum.
type ReferenceSolution(matrix: int array array) =
    inherit NumMatrix(matrix)
    let rows = matrix.Length
    let cols = matrix[0].Length
    let prefix = Array.init (rows + 1) (fun _ -> Array.zeroCreate<int> (cols + 1))

    do
        for row in 0 .. rows - 1 do
            for column in 0 .. cols - 1 do
                prefix[row + 1][column + 1] <-
                    matrix[row][column]
                    + prefix[row][column + 1]
                    + prefix[row + 1][column]
                    - prefix[row][column]

    override _.SumRegion row1 col1 row2 col2 =
        prefix[row2 + 1][col2 + 1]
        - prefix[row1][col2 + 1]
        - prefix[row2 + 1][col1]
        + prefix[row1][col1]

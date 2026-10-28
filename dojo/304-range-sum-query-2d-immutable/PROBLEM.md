# Drill 304: Range Sum Query 2D: Immutable

LeetCode Medium: https://leetcode.com/problems/range-sum-query-2d-immutable/

Implement `NumMatrix(int[][] matrix)` and `SumRegion(int row1, int col1, int row2, int col2)`. Return the sum of the inclusive rectangle between valid top-left and bottom-right coordinates. The matrix never changes. Aim for O(1) queries.

Constraints: 1 to 200 rows and columns, values in [-10,000,10,000]; at most 10,000 queries.

Example: `[[1,2],[3,4]]`, query `(0,0,1,1)` returns `10`.

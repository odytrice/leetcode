// O(m * n) time, O(n) space. Each cell adds its left and above neighbours.
export function uniquePaths(m: number, n: number): number {
  // dp[column] is the number of paths to that cell in the current row; the first row is all 1s.
  const dp = new Array<number>(n).fill(1);
  for (let row = 1; row < m; row += 1) {
    for (let column = 1; column < n; column += 1) {
      // dp[column] still holds the value from above; dp[column - 1] is the cell to the left.
      dp[column] += dp[column - 1];
    }
  }
  return dp[n - 1];
}

// O(m * n) time, O(n) space. Each cell adds its left and above neighbours.
export function uniquePaths(m: number, n: number): number {
  const dp = new Array<number>(n).fill(1);
  for (let row = 1; row < m; row += 1) {
    for (let column = 1; column < n; column += 1) {
      dp[column] += dp[column - 1];
    }
  }
  return dp[n - 1];
}

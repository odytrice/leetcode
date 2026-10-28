// O(len1 * len2) time, O(len2) space. Keeps one row and the diagonal.
export function longestCommonSubsequence(text1: string, text2: string): number {
  const dp = new Array<number>(text2.length + 1).fill(0);
  for (const first of text1) {
    let diagonal = 0;
    for (let column = 1; column <= text2.length; column++) {
      const previous = dp[column];
      dp[column] = first === text2[column - 1] ? diagonal + 1 : Math.max(dp[column], dp[column - 1]);
      diagonal = previous;
    }
  }
  return dp[text2.length];
}

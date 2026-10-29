// O(len1 * len2) time, O(len2) space. Keeps one row and the diagonal.
export function longestCommonSubsequence(text1: string, text2: string): number {
  // dp[column] is the LCS of the processed part of text1 and the first column chars of text2.
  const dp = new Array<number>(text2.length + 1).fill(0);
  for (const first of text1) {
    // diagonal holds the old dp[column - 1] from the previous row.
    let diagonal = 0;
    for (let column = 1; column <= text2.length; column += 1) {
      const previous = dp[column];
      // A match extends the diagonal; otherwise take the better of dropping one character.
      dp[column] = first === text2[column - 1] ? diagonal + 1 : Math.max(dp[column], dp[column - 1]);
      diagonal = previous;
    }
  }
  return dp[text2.length];
}

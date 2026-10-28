// O(n * max word length) time. dp[i] is true when s.slice(0, i) can be segmented.
export function wordBreak(s: string, wordDict: string[]): boolean {
  const words = new Set(wordDict);
  const longest = wordDict.reduce((best, word) => Math.max(best, word.length), 0);
  const dp = new Array<boolean>(s.length + 1).fill(false);
  dp[0] = true;
  for (let end = 1; end <= s.length; end++) {
    for (let start = Math.max(0, end - longest); start < end; start++) {
      if (dp[start] && words.has(s.slice(start, end))) {
        dp[end] = true;
        break;
      }
    }
  }
  return dp[s.length];
}

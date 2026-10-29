// O(n * max word length) time. dp[i] is true when s.slice(0, i) can be segmented.
export function wordBreak(s: string, wordDict: string[]): boolean {
  const words = new Set(wordDict);
  const longest = wordDict.reduce((best, word) => Math.max(best, word.length), 0);
  const dp = new Array<boolean>(s.length + 1).fill(false);
  // The empty prefix is always segmentable.
  dp[0] = true;
  for (let end = 1; end <= s.length; end += 1) {
    // Only words up to the longest dictionary length can end at end, so skip starts further back.
    for (let start = Math.max(0, end - longest); start < end; start += 1) {
      // A segmentable prefix followed by a dictionary word makes s.slice(0, end) segmentable.
      if (dp[start] && words.has(s.slice(start, end))) {
        dp[end] = true;
        break;
      }
    }
  }
  return dp[s.length];
}

// O(n) time. A window is valid when everything but its most common letter fits in k.
export function characterReplacement(s: string, k: number): number {
  const counts = new Map<string, number>();
  let left = 0;
  let best = 0;
  // most is the highest count of one letter seen in any window so far.
  let most = 0;
  for (let right = 0; right < s.length; right += 1) {
    const count = (counts.get(s[right]) ?? 0) + 1;
    counts.set(s[right], count);
    most = Math.max(most, count);
    // Letters other than the most common one need replacing; shrink while there are more than k.
    while (right - left + 1 - most > k) {
      counts.set(s[left], (counts.get(s[left]) ?? 0) - 1);
      left += 1;
    }
    // most is never lowered: a stale value only keeps the window size, and best grows only with a new max.
    best = Math.max(best, right - left + 1);
  }
  return best;
}

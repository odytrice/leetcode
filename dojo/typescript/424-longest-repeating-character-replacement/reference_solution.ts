// O(n) time. A window is valid when everything but its most common letter fits in k.
export function characterReplacement(s: string, k: number): number {
  const counts = new Map<string, number>();
  let left = 0;
  let best = 0;
  let most = 0;
  for (let right = 0; right < s.length; right += 1) {
    const count = (counts.get(s[right]) ?? 0) + 1;
    counts.set(s[right], count);
    most = Math.max(most, count);
    while (right - left + 1 - most > k) {
      counts.set(s[left], (counts.get(s[left]) ?? 0) - 1);
      left += 1;
    }
    best = Math.max(best, right - left + 1);
  }
  return best;
}

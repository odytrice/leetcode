// O(n) time. Each character's last position moves the window's left edge.
export function lengthOfLongestSubstring(s: string): number {
  const last = new Map<string, number>();
  let left = 0;
  let best = 0;
  for (let right = 0; right < s.length; right++) {
    const previous = last.get(s[right]);
    if (previous !== undefined) left = Math.max(left, previous + 1);
    last.set(s[right], right);
    best = Math.max(best, right - left + 1);
  }
  return best;
}

// O(n) time. Each character's last position moves the window's left edge.
export function lengthOfLongestSubstring(s: string): number {
  // Maps each character to the last index where it appeared.
  const last = new Map<string, number>();
  let left = 0;
  let best = 0;
  for (let right = 0; right < s.length; right += 1) {
    const previous = last.get(s[right]);
    // A repeat inside the window pushes left just past its earlier copy; never move left backwards.
    if (previous !== undefined) {
      left = Math.max(left, previous + 1);
    }
    last.set(s[right], right);
    // The window s[left..right] now has no repeated characters.
    best = Math.max(best, right - left + 1);
  }
  return best;
}

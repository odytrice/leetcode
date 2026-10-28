// O(n) time. Only start counting at values with no predecessor.
export function longestConsecutive(nums: number[]): number {
  const values = new Set(nums);
  let best = 0;
  for (const value of values) {
    if (values.has(value - 1)) continue;
    let length = 1;
    while (values.has(value + length)) length++;
    best = Math.max(best, length);
  }
  return best;
}

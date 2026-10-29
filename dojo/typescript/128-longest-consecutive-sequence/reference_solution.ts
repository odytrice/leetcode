// O(n) time. Only start counting at values with no predecessor.
export function longestConsecutive(nums: number[]): number {
  const values = new Set(nums);
  let best = 0;
  for (const value of values) {
    // A value with a predecessor is inside some run, so its run is counted from the run's start.
    if (values.has(value - 1)) {
      continue;
    }
    let length = 1;
    // Count upward from the start of this run.
    while (values.has(value + length)) {
      length += 1;
    }
    best = Math.max(best, length);
  }
  return best;
}

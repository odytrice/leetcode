// O(n) time, O(1) space. Each house either skips or adds to the total two back.
export function rob(nums: number[]): number {
  let previous = 0;
  let best = 0;
  for (const value of nums) {
    const next = Math.max(best, previous + value);
    previous = best;
    best = next;
  }
  return best;
}

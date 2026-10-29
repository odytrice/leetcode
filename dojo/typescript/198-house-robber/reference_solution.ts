// O(n) time, O(1) space. Each house either skips or adds to the total two back.
export function rob(nums: number[]): number {
  // previous is the best total two houses back, best is the best total up to the last house.
  let previous = 0;
  let best = 0;
  for (const value of nums) {
    // Either skip this house, or rob it on top of the best total from two houses back.
    const next = Math.max(best, previous + value);
    previous = best;
    best = next;
  }
  return best;
}

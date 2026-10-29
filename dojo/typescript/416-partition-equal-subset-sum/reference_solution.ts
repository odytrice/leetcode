// O(n * sum) time, O(sum) space. Descending totals prevent reusing one number.
export function canPartition(nums: number[]): boolean {
  const total = nums.reduce((sum, value) => sum + value, 0);
  // An odd total cannot be split into two equal halves.
  if (total % 2 !== 0) {
    return false;
  }
  const target = total / 2;
  // reachable[s] is true when some subset of the numbers so far sums to s.
  const reachable = new Array<boolean>(target + 1).fill(false);
  reachable[0] = true;
  for (const value of nums) {
    // Going downwards means reachable[subtotal - value] is still from before this value was added.
    for (let subtotal = target; subtotal >= value; subtotal -= 1) {
      if (reachable[subtotal - value]) {
        reachable[subtotal] = true;
      }
    }
  }
  return reachable[target];
}

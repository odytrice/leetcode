// O(n * sum) time, O(sum) space. Descending totals prevent reusing one number.
export function canPartition(nums: number[]): boolean {
  const total = nums.reduce((sum, value) => sum + value, 0);
  if (total % 2 !== 0) return false;
  const target = total / 2;
  const reachable = new Array<boolean>(target + 1).fill(false);
  reachable[0] = true;
  for (const value of nums) {
    for (let subtotal = target; subtotal >= value; subtotal--) {
      if (reachable[subtotal - value]) reachable[subtotal] = true;
    }
  }
  return reachable[target];
}

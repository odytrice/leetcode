// O(n) time, O(1) space. Shrink the window while it still reaches the target.
export function minSubArrayLen(target: number, nums: number[]): number {
  let left = 0;
  let total = 0;
  let best = nums.length + 1;
  for (let right = 0; right < nums.length; right += 1) {
    total += nums[right];
    while (total >= target) {
      best = Math.min(best, right - left + 1);
      total -= nums[left];
      left += 1;
    }
  }
  return best > nums.length ? 0 : best;
}

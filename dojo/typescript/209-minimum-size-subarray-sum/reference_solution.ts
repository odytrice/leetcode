// O(n) time, O(1) space. Shrink the window while it still reaches the target.
export function minSubArrayLen(target: number, nums: number[]): number {
  let left = 0;
  let total = 0;
  // nums.length + 1 is a sentinel meaning no valid window has been found yet.
  let best = nums.length + 1;
  for (let right = 0; right < nums.length; right += 1) {
    total += nums[right];
    // While the window meets the target, record it and try a shorter one from the left.
    while (total >= target) {
      best = Math.min(best, right - left + 1);
      total -= nums[left];
      left += 1;
    }
  }
  // The sentinel survived, so no subarray reaches the target.
  return best > nums.length ? 0 : best;
}

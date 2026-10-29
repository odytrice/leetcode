// O(n) time. The window may hold at most k zeros.
export function longestOnes(nums: number[], k: number): number {
  let left = 0;
  let zeros = 0;
  let best = 0;
  for (let right = 0; right < nums.length; right += 1) {
    // A zero inside the window is one we would flip to a one.
    if (nums[right] === 0) {
      zeros += 1;
    }
    // Too many flips: shrink from the left until the window is valid again.
    while (zeros > k) {
      if (nums[left] === 0) {
        zeros -= 1;
      }
      left += 1;
    }
    // The window now holds at most k zeros, so all of it can become ones.
    best = Math.max(best, right - left + 1);
  }
  return best;
}

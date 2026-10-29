// O(n) time. Tracks the furthest reachable index.
export function canJump(nums: number[]): boolean {
  // reach is the furthest index we can get to from anything visited so far.
  let reach = 0;
  for (let index = 0; index < nums.length; index += 1) {
    // If this index is beyond reach, we are stuck before it.
    if (index > reach) {
      return false;
    }
    reach = Math.max(reach, index + nums[index]);
    // Stop early once the last index is reachable.
    if (reach >= nums.length - 1) {
      return true;
    }
  }
  return true;
}

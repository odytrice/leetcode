// O(n) time. Tracks the furthest reachable index.
export function canJump(nums: number[]): boolean {
  let reach = 0;
  for (let index = 0; index < nums.length; index += 1) {
    if (index > reach) {
      return false;
    }
    reach = Math.max(reach, index + nums[index]);
    if (reach >= nums.length - 1) {
      return true;
    }
  }
  return true;
}

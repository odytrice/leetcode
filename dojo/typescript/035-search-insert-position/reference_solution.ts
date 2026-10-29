// O(log n) time. Finds the first index whose value is not below the target.
export function searchInsert(nums: number[], target: number): number {
  let left = 0;
  let right = nums.length;
  // Invariant: everything before left is below target, everything from right on is not.
  while (left < right) {
    const middle = (left + right) >> 1;
    if (nums[middle] < target) {
      left = middle + 1;
    } else {
      right = middle;
    }
  }
  // left is where the target is, or where it would be inserted.
  return left;
}

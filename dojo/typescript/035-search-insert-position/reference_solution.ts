// O(log n) time. Finds the first index whose value is not below the target.
export function searchInsert(nums: number[], target: number): number {
  let left = 0;
  let right = nums.length;
  while (left < right) {
    const middle = (left + right) >> 1;
    if (nums[middle] < target) {
      left = middle + 1;
    } else {
      right = middle;
    }
  }
  return left;
}

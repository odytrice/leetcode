// O(log n) time. The minimum is where the order breaks.
export function findMin(nums: number[]): number {
  let left = 0;
  let right = nums.length - 1;
  while (left < right) {
    const middle = (left + right) >> 1;
    if (nums[middle] > nums[right]) {
      left = middle + 1;
    } else {
      right = middle;
    }
  }
  return nums[left];
}

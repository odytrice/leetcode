// O(log n) time. The minimum is where the order breaks.
export function findMin(nums: number[]): number {
  let left = 0;
  let right = nums.length - 1;
  // Invariant: the minimum is always inside [left, right].
  while (left < right) {
    const middle = (left + right) >> 1;
    // middle above right means the drop, and so the minimum, is to the right of middle.
    if (nums[middle] > nums[right]) {
      left = middle + 1;
    } else {
      // Otherwise middle..right is sorted, so the minimum is at middle or to its left.
      right = middle;
    }
  }
  return nums[left];
}

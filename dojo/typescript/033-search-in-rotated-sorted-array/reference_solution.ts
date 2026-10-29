// O(log n) time. Decides which half is sorted, then whether the target is in it.
export function search(nums: number[], target: number): number {
  let left = 0;
  let right = nums.length - 1;
  while (left <= right) {
    const middle = (left + right) >> 1;
    if (nums[middle] === target) {
      return middle;
    }
    // At least one half is always sorted; check whether the left half is.
    if (nums[left] <= nums[middle]) {
      // The target can only be in the sorted left half if it falls inside its range.
      if (nums[left] <= target && target < nums[middle]) {
        right = middle - 1;
      } else {
        left = middle + 1;
      }
    // Otherwise the right half is sorted; check whether the target falls inside it.
    } else if (nums[middle] < target && target <= nums[right]) {
      left = middle + 1;
    } else {
      right = middle - 1;
    }
  }
  // -1 means the target is not in the array.
  return -1;
}

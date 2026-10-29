// O(log n) time. Two lower-bound searches: one for the target, one past it.
export function searchRange(nums: number[], target: number): number[] {
  // Returns the first index whose value is >= target, or > target when upper is true.
  const bound = (upper: boolean): number => {
    let left = 0;
    let right = nums.length;
    while (left < right) {
      const middle = (left + right) >> 1;
      if (nums[middle] < target || (upper && nums[middle] === target)) {
        left = middle + 1;
      } else {
        right = middle;
      }
    }
    return left;
  };
  const first = bound(false);
  // If the first candidate is out of range or a different value, the target is absent.
  if (first === nums.length || nums[first] !== target) {
    return [-1, -1];
  }
  // The first index past the target, minus one, is its last position.
  return [first, bound(true) - 1];
}

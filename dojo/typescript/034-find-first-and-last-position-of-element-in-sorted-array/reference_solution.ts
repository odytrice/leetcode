// O(log n) time. Two lower-bound searches: one for the target, one past it.
export function searchRange(nums: number[], target: number): number[] {
  const bound = (upper: boolean): number => {
    let left = 0;
    let right = nums.length;
    while (left < right) {
      const middle = (left + right) >> 1;
      if (nums[middle] < target || (upper && nums[middle] === target)) left = middle + 1;
      else right = middle;
    }
    return left;
  };
  const first = bound(false);
  if (first === nums.length || nums[first] !== target) return [-1, -1];
  return [first, bound(true) - 1];
}

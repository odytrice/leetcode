// O(n) time, O(1) space. Dutch national flag: grow the 0 and 2 regions inward.
export function sortColors(nums: number[]): void {
  // Invariant: [0, low) is 0s, [low, index) is 1s, and (high, end] is 2s.
  let low = 0;
  let index = 0;
  let high = nums.length - 1;
  while (index <= high) {
    if (nums[index] === 0) {
      [nums[low], nums[index]] = [nums[index], nums[low]];
      low += 1;
      index += 1;
    } else if (nums[index] === 2) {
      // Do not advance index here: the value swapped in from high has not been checked yet.
      [nums[high], nums[index]] = [nums[index], nums[high]];
      high -= 1;
    } else {
      index += 1;
    }
  }
}

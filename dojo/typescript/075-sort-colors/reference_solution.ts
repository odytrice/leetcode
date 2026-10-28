// O(n) time, O(1) space. Dutch national flag: grow the 0 and 2 regions inward.
export function sortColors(nums: number[]): void {
  let low = 0;
  let index = 0;
  let high = nums.length - 1;
  while (index <= high) {
    if (nums[index] === 0) {
      [nums[low], nums[index]] = [nums[index], nums[low]];
      low++;
      index++;
    } else if (nums[index] === 2) {
      [nums[high], nums[index]] = [nums[index], nums[high]];
      high--;
    } else {
      index++;
    }
  }
}

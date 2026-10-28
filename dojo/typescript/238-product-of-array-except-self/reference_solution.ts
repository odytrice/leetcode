// O(n) time, O(1) extra space. Writes prefixes, then multiplies suffixes.
export function productExceptSelf(nums: number[]): number[] {
  const result = new Array<number>(nums.length).fill(1);
  let prefix = 1;
  let suffix = 1;
  for (let index = 0; index < nums.length; index++) {
    result[index] = prefix;
    prefix *= nums[index];
  }
  for (let index = nums.length - 1; index >= 0; index--) {
    result[index] *= suffix;
    suffix *= nums[index];
  }
  return result;
}

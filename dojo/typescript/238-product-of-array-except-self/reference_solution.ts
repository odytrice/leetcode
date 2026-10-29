// O(n) time, O(1) extra space. Writes prefixes, then multiplies suffixes.
export function productExceptSelf(nums: number[]): number[] {
  const result = new Array<number>(nums.length).fill(1);
  let prefix = 1;
  let suffix = 1;
  // First pass: result[index] becomes the product of everything left of index.
  for (let index = 0; index < nums.length; index += 1) {
    result[index] = prefix;
    prefix *= nums[index];
  }
  // Second pass: multiply in the product of everything right of index.
  for (let index = nums.length - 1; index >= 0; index -= 1) {
    result[index] *= suffix;
    suffix *= nums[index];
  }
  return result;
}

// O(n) time. A repeated remainder means a subarray divisible by k.
export function checkSubarraySum(nums: number[], k: number): boolean {
  const first = new Map<number, number>([[0, -1]]);
  let total = 0;
  for (let index = 0; index < nums.length; index += 1) {
    total += nums[index];
    const remainder = total % k;
    const start = first.get(remainder);
    if (start === undefined) {
      first.set(remainder, index);
    } else if (index - start >= 2) {
      return true;
    }
  }
  return false;
}

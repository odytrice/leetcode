// O(n) time. A repeated remainder means a subarray divisible by k.
export function checkSubarraySum(nums: number[], k: number): boolean {
  // Maps each prefix-sum remainder to the first index where it appeared; index -1 is the empty prefix.
  const first = new Map<number, number>([[0, -1]]);
  let total = 0;
  for (let index = 0; index < nums.length; index += 1) {
    total += nums[index];
    const remainder = total % k;
    const start = first.get(remainder);
    // Only store the first index, so later matches give the longest subarray.
    if (start === undefined) {
      first.set(remainder, index);
    // Same remainder twice means the sum between them is a multiple of k; it must have length >= 2.
    } else if (index - start >= 2) {
      return true;
    }
  }
  return false;
}

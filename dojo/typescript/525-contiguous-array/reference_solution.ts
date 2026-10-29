// O(n) time. Equal zeros and ones means a repeated running balance.
export function findMaxLength(nums: number[]): number {
  // Maps each balance to the first index where it appeared; index -1 is the empty prefix.
  const first = new Map<number, number>([[0, -1]]);
  let balance = 0;
  let best = 0;
  for (let index = 0; index < nums.length; index += 1) {
    // Count a 1 as +1 and a 0 as -1, so an equal mix sums to 0.
    balance += nums[index] === 1 ? 1 : -1;
    const start = first.get(balance);
    // Only store the first index, so later matches give the longest subarray.
    if (start === undefined) {
      first.set(balance, index);
    } else {
      // Same balance twice means the part between has as many 0s as 1s.
      best = Math.max(best, index - start);
    }
  }
  return best;
}

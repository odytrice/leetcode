// O(n log n) time. tails[k] is the smallest tail of an increasing run of length k + 1.
export function lengthOfLIS(nums: number[]): number {
  const tails: number[] = [];
  for (const value of nums) {
    let low = 0;
    let high = tails.length;
    while (low < high) {
      const middle = (low + high) >> 1;
      if (tails[middle] < value) {
        low = middle + 1;
      } else {
        high = middle;
      }
    }
    if (low === tails.length) {
      tails.push(value);
    } else {
      tails[low] = value;
    }
  }
  return tails.length;
}

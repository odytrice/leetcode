// O(n) time. Equal zeros and ones means a repeated running balance.
export function findMaxLength(nums: number[]): number {
  const first = new Map<number, number>([[0, -1]]);
  let balance = 0;
  let best = 0;
  for (let index = 0; index < nums.length; index++) {
    balance += nums[index] === 1 ? 1 : -1;
    const start = first.get(balance);
    if (start === undefined) first.set(balance, index);
    else best = Math.max(best, index - start);
  }
  return best;
}

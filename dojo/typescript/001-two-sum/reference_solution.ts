// O(n) time and space. Remembers each value's index before it is needed.
export function twoSum(nums: number[], target: number): number[] {
  const seen = new Map<number, number>();
  for (let index = 0; index < nums.length; index++) {
    const partner = seen.get(target - nums[index]);
    if (partner !== undefined) return [partner, index];
    seen.set(nums[index], index);
  }
  throw new Error("No answer");
}

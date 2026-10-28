// O(n) time and space. Counts earlier prefixes whose difference is k.
export function subarraySum(nums: number[], k: number): number {
  const counts = new Map<number, number>([[0, 1]]);
  let total = 0;
  let answer = 0;
  for (const value of nums) {
    total += value;
    answer += counts.get(total - k) ?? 0;
    counts.set(total, (counts.get(total) ?? 0) + 1);
  }
  return answer;
}

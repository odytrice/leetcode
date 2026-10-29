// O(n) time and space. Counts earlier prefixes whose difference is k.
export function subarraySum(nums: number[], k: number): number {
  // counts maps each prefix sum to how often it has appeared; the empty prefix has sum 0.
  const counts = new Map<number, number>([[0, 1]]);
  let total = 0;
  let answer = 0;
  for (const value of nums) {
    total += value;
    // Each earlier prefix equal to total - k starts a subarray ending here that sums to k.
    answer += counts.get(total - k) ?? 0;
    // Record this prefix after counting, so a subarray is never empty.
    counts.set(total, (counts.get(total) ?? 0) + 1);
  }
  return answer;
}

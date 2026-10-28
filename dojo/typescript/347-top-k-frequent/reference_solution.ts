// O(n) time. Buckets values by frequency, then reads from the top.
export function topKFrequent(nums: number[], k: number): number[] {
  const counts = new Map<number, number>();
  for (const value of nums) counts.set(value, (counts.get(value) ?? 0) + 1);
  const buckets: number[][] = Array.from({ length: nums.length + 1 }, () => []);
  for (const [value, count] of counts) buckets[count].push(value);
  const result: number[] = [];
  for (let count = nums.length; count > 0 && result.length < k; count--) {
    for (const value of buckets[count]) {
      result.push(value);
      if (result.length === k) break;
    }
  }
  return result;
}

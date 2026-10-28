// O(n log k) time. Sorts a copy and reads the kth largest; simple and fast enough.
export function findKthLargest(nums: number[], k: number): number {
  const sorted = [...nums].sort((a, b) => b - a);
  return sorted[k - 1];
}

// O(n log n) time. Sorts a copy in descending order and reads the kth value; simple and fast enough.
export function findKthLargest(nums: number[], k: number): number {
  const sorted = [...nums].sort((a, b) => b - a);
  // Index k - 1 because the largest value sits at index 0.
  return sorted[k - 1];
}

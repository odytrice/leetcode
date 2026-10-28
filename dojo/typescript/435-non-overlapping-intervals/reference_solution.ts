// O(n log n) time. Greedily keeps the interval that ends earliest.
export function eraseOverlapIntervals(intervals: number[][]): number {
  const sorted = [...intervals].sort((a, b) => a[1] - b[1]);
  let end = Number.NEGATIVE_INFINITY;
  let kept = 0;
  for (const [start, finish] of sorted) {
    if (start >= end) {
      kept++;
      end = finish;
    }
  }
  return intervals.length - kept;
}

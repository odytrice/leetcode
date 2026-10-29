// O(n log n) time. Greedily keeps the interval that ends earliest.
export function eraseOverlapIntervals(intervals: number[][]): number {
  // Sorting by end lets us keep the interval that leaves the most room for the rest.
  const sorted = [...intervals].sort((a, b) => a[1] - b[1]);
  // end is where the last kept interval finishes.
  let end = Number.NEGATIVE_INFINITY;
  let kept = 0;
  for (const [start, finish] of sorted) {
    // Touching at a point is not an overlap, so >= is allowed.
    if (start >= end) {
      kept += 1;
      end = finish;
    }
  }
  // Everything we did not keep must be removed.
  return intervals.length - kept;
}

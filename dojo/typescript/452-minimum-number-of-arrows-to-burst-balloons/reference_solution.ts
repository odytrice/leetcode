// O(n log n) time. Shoots at the earliest finishing balloon that is still uncovered.
export function findMinArrowShots(points: number[][]): number {
  // Sorting by end means shooting at each end bursts as many later balloons as possible.
  const sorted = [...points].sort((a, b) => a[1] - b[1]);
  let arrows = 0;
  // end is the x position of the last arrow.
  let end = Number.NEGATIVE_INFINITY;
  for (const [start, finish] of sorted) {
    // This balloon starts after the last arrow, so it needs a new one at its own end.
    if (start > end) {
      arrows += 1;
      end = finish;
    }
  }
  return arrows;
}

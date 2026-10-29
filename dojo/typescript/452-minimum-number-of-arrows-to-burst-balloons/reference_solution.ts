// O(n log n) time. Shoots at the earliest finishing balloon that is still uncovered.
export function findMinArrowShots(points: number[][]): number {
  const sorted = [...points].sort((a, b) => a[1] - b[1]);
  let arrows = 0;
  let end = Number.NEGATIVE_INFINITY;
  for (const [start, finish] of sorted) {
    if (start > end) {
      arrows += 1;
      end = finish;
    }
  }
  return arrows;
}

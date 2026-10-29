// O(n log n) time. Sorts by start, then extends or opens a new interval.
export function merge(intervals: number[][]): number[][] {
  // After sorting, any overlap can only be with the last interval in the result.
  const sorted = [...intervals].sort((a, b) => a[0] - b[0]);
  const result: number[][] = [];
  for (const [start, end] of sorted) {
    const last = result[result.length - 1];
    // The current interval starts before the last one ends, so they overlap.
    if (last !== undefined && last[1] >= start) {
      last[1] = Math.max(last[1], end);
    } else {
      result.push([start, end]);
    }
  }
  return result;
}

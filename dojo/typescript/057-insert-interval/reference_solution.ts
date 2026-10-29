// O(n) time. Copies the earlier intervals, absorbs the overlap, then copies the rest.
export function insert(intervals: number[][], newInterval: number[]): number[][] {
  const result: number[][] = [];
  let index = 0;
  let [start, end] = newInterval;
  // Phase 1: intervals that end before the new one starts stay unchanged.
  while (index < intervals.length && intervals[index][1] < start) {
    result.push([...intervals[index]]);
    index += 1;
  }
  // Phase 2: anything that starts before the new interval ends overlaps it; widen to cover it.
  while (index < intervals.length && intervals[index][0] <= end) {
    start = Math.min(start, intervals[index][0]);
    end = Math.max(end, intervals[index][1]);
    index += 1;
  }
  result.push([start, end]);
  // Phase 3: the remaining intervals start after the merged one ends.
  while (index < intervals.length) {
    result.push([...intervals[index]]);
    index += 1;
  }
  return result;
}

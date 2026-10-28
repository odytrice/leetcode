// O(n) time. Copies the earlier intervals, absorbs the overlap, then copies the rest.
export function insert(intervals: number[][], newInterval: number[]): number[][] {
  const result: number[][] = [];
  let index = 0;
  let [start, end] = newInterval;
  while (index < intervals.length && intervals[index][1] < start) {
    result.push([...intervals[index]]);
    index++;
  }
  while (index < intervals.length && intervals[index][0] <= end) {
    start = Math.min(start, intervals[index][0]);
    end = Math.max(end, intervals[index][1]);
    index++;
  }
  result.push([start, end]);
  while (index < intervals.length) {
    result.push([...intervals[index]]);
    index++;
  }
  return result;
}

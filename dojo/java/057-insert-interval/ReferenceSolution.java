import java.util.ArrayList;
import java.util.List;

/** O(n) time. Copies the earlier intervals, absorbs the overlap, then copies the rest. */
class ReferenceSolution extends Solution {
    @Override
    public int[][] insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new ArrayList<>();
        int index = 0;
        int start = newInterval[0];
        int end = newInterval[1];
        // Phase 1: intervals that end before the new one starts are untouched.
        while (index < intervals.length && intervals[index][1] < start) {
            result.add(new int[] {intervals[index][0], intervals[index][1]});
            index += 1;
        }
        // Phase 2: every interval that starts before the new one ends overlaps it, so merge them.
        while (index < intervals.length && intervals[index][0] <= end) {
            start = Math.min(start, intervals[index][0]);
            end = Math.max(end, intervals[index][1]);
            index += 1;
        }
        result.add(new int[] {start, end});
        // Phase 3: the remaining intervals all start after the merged one.
        while (index < intervals.length) {
            result.add(new int[] {intervals[index][0], intervals[index][1]});
            index += 1;
        }
        return result.toArray(new int[0][]);
    }
}

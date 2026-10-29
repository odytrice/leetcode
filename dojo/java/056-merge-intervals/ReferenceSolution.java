import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(n log n) time. Sorts by start, then extends or opens a new interval. */
class ReferenceSolution extends Solution {
    @Override
    public int[][] merge(int[][] intervals) {
        // After sorting by start, any overlap can only be with the last merged interval.
        Arrays.sort(intervals, (a, b) -> Integer.compare(a[0], b[0]));
        List<int[]> result = new ArrayList<>();
        for (int[] interval : intervals) {
            int[] last = result.isEmpty() ? null : result.get(result.size() - 1);
            // It starts before the last one ends, so stretch the last one to cover it.
            if (last != null && last[1] >= interval[0]) {
                last[1] = Math.max(last[1], interval[1]);
            } else {
                // Copy it so later merges never change the caller's input arrays.
                result.add(new int[] {interval[0], interval[1]});
            }
        }
        return result.toArray(new int[0][]);
    }
}

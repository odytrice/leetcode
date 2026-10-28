import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(n log n) time. Sorts by start, then extends or opens a new interval. */
class ReferenceSolution extends Solution {
    @Override
    public int[][] merge(int[][] intervals) {
        Arrays.sort(intervals, (a, b) -> Integer.compare(a[0], b[0]));
        List<int[]> result = new ArrayList<>();
        for (int[] interval : intervals) {
            int[] last = result.isEmpty() ? null : result.get(result.size() - 1);
            if (last != null && last[1] >= interval[0]) {
                last[1] = Math.max(last[1], interval[1]);
            } else {
                result.add(new int[] {interval[0], interval[1]});
            }
        }
        return result.toArray(new int[0][]);
    }
}

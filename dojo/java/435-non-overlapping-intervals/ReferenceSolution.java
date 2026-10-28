import java.util.Arrays;

/** O(n log n) time. Greedily keeps the interval that ends earliest. */
class ReferenceSolution extends Solution {
    @Override
    public int eraseOverlapIntervals(int[][] intervals) {
        Arrays.sort(intervals, (a, b) -> Integer.compare(a[1], b[1]));
        long end = Long.MIN_VALUE;
        int kept = 0;
        for (int[] interval : intervals) {
            if (interval[0] >= end) {
                kept++;
                end = interval[1];
            }
        }
        return intervals.length - kept;
    }
}

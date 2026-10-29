import java.util.Arrays;

/** O(n log n) time. Greedily keeps the interval that ends earliest. */
class ReferenceSolution extends Solution {
    @Override
    public int eraseOverlapIntervals(int[][] intervals) {
        // Sort by end: the earliest end leaves the most room for the intervals after it.
        Arrays.sort(intervals, (a, b) -> Integer.compare(a[1], b[1]));
        // end is where the last kept interval finishes; the long minimum lets the first one through.
        long end = Long.MIN_VALUE;
        int kept = 0;
        for (int[] interval : intervals) {
            // Touching at an endpoint does not count as overlapping.
            if (interval[0] >= end) {
                kept += 1;
                end = interval[1];
            }
        }
        // Every interval not kept is one we had to remove.
        return intervals.length - kept;
    }
}

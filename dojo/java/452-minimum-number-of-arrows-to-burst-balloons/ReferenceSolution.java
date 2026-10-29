import java.util.Arrays;

/** O(n log n) time. Shoots at the earliest finishing balloon that is still uncovered. */
class ReferenceSolution extends Solution {
    @Override
    public int findMinArrowShots(int[][] points) {
        // Integer.compare avoids the overflow that a[1] - b[1] could cause with extreme values.
        Arrays.sort(points, (a, b) -> Integer.compare(a[1], b[1]));
        int arrows = 0;
        // end is the x position of the last arrow; the long minimum is below every balloon.
        long end = Long.MIN_VALUE;
        for (int[] point : points) {
            // This balloon starts after the last arrow, so it needs a new one at its own end.
            if (point[0] > end) {
                arrows += 1;
                end = point[1];
            }
        }
        return arrows;
    }
}

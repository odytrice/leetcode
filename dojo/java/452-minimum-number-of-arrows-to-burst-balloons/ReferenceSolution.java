import java.util.Arrays;

/** O(n log n) time. Shoots at the earliest finishing balloon that is still uncovered. */
class ReferenceSolution extends Solution {
    @Override
    public int findMinArrowShots(int[][] points) {
        Arrays.sort(points, (a, b) -> Integer.compare(a[1], b[1]));
        int arrows = 0;
        long end = Long.MIN_VALUE;
        for (int[] point : points) {
            if (point[0] > end) {
                arrows++;
                end = point[1];
            }
        }
        return arrows;
    }
}

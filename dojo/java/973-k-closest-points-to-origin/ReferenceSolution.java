import java.util.Arrays;

/** O(n log n) time. Sorting by squared distance keeps the arithmetic exact. */
class ReferenceSolution extends Solution {
    @Override
    public int[][] kClosest(int[][] points, int k) {
        // Skipping the square root keeps the same order and avoids floating point.
        Arrays.sort(points, (a, b) -> (a[0] * a[0] + a[1] * a[1]) - (b[0] * b[0] + b[1] * b[1]));
        // After sorting, the first k points are the closest.
        return Arrays.copyOfRange(points, 0, k);
    }
}

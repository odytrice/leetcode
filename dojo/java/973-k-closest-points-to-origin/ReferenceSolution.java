import java.util.Arrays;

/** O(n log n) time. Sorting by squared distance keeps the arithmetic exact. */
class ReferenceSolution extends Solution {
    @Override
    public int[][] kClosest(int[][] points, int k) {
        Arrays.sort(points, (a, b) -> (a[0] * a[0] + a[1] * a[1]) - (b[0] * b[0] + b[1] * b[1]));
        return Arrays.copyOfRange(points, 0, k);
    }
}

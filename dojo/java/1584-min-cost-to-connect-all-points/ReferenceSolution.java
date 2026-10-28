import java.util.Arrays;

/** O(n^2) time. Dense Prim: picks the cheapest link to the growing tree. */
class ReferenceSolution extends Solution {
    @Override
    public int minCostConnectPoints(int[][] points) {
        int size = points.length;
        boolean[] used = new boolean[size];
        int[] best = new int[size];
        Arrays.fill(best, Integer.MAX_VALUE);
        best[0] = 0;
        int total = 0;
        for (int step = 0; step < size; step++) {
            int chosen = -1;
            for (int node = 0; node < size; node++) {
                if (!used[node] && (chosen == -1 || best[node] < best[chosen])) {
                    chosen = node;
                }
            }
            used[chosen] = true;
            total += best[chosen];
            for (int node = 0; node < size; node++) {
                if (!used[node]) {
                    int cost = Math.abs(points[chosen][0] - points[node][0])
                            + Math.abs(points[chosen][1] - points[node][1]);
                    best[node] = Math.min(best[node], cost);
                }
            }
        }
        return total;
    }
}

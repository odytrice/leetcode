import java.util.Arrays;

/** O(n^2) time. Dense Prim: picks the cheapest link to the growing tree. */
class ReferenceSolution extends Solution {
    @Override
    public int minCostConnectPoints(int[][] points) {
        int size = points.length;
        // used marks points already in the tree.
        boolean[] used = new boolean[size];
        // best[node] is the cheapest edge from node to any point already in the tree.
        int[] best = new int[size];
        Arrays.fill(best, Integer.MAX_VALUE);
        // Point 0 starts the tree at no cost.
        best[0] = 0;
        int total = 0;
        for (int step = 0; step < size; step += 1) {
            // Pick the unused point that is cheapest to attach.
            int chosen = -1;
            for (int node = 0; node < size; node += 1) {
                if (!used[node] && (chosen == -1 || best[node] < best[chosen])) {
                    chosen = node;
                }
            }
            used[chosen] = true;
            total += best[chosen];
            // The new point may offer a cheaper link to the points still outside.
            for (int node = 0; node < size; node += 1) {
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

import java.util.Arrays;

/** O(k * flights) time. Bellman-Ford rounds, each using at most one new edge. */
class ReferenceSolution extends Solution {
    @Override
    public int findCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        // distance[v] is the cheapest price to v using at most `round` flights so far.
        int[] distance = new int[n];
        Arrays.fill(distance, Integer.MAX_VALUE);
        distance[src] = 0;
        // k stops means at most k + 1 flights, so run k + 1 rounds.
        for (int round = 0; round <= k; round += 1) {
            // Write into a copy so a single round cannot chain two flights together.
            int[] following = distance.clone();
            for (int[] flight : flights) {
                // Skip unreachable sources; adding to MAX_VALUE would overflow.
                if (distance[flight[0]] != Integer.MAX_VALUE) {
                    following[flight[1]] = Math.min(following[flight[1]], distance[flight[0]] + flight[2]);
                }
            }
            distance = following;
        }
        return distance[dst] == Integer.MAX_VALUE ? -1 : distance[dst];
    }
}

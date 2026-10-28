import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.PriorityQueue;

/** O(edges log nodes) time. Dijkstra from the source; the answer is the farthest arrival. */
class ReferenceSolution extends Solution {
    @Override
    public int networkDelayTime(int[][] times, int n, int k) {
        List<List<int[]>> graph = new ArrayList<>();
        for (int node = 0; node <= n; node++) {
            graph.add(new ArrayList<>());
        }
        for (int[] edge : times) {
            graph.get(edge[0]).add(new int[] {edge[1], edge[2]});
        }

        int[] distance = new int[n + 1];
        Arrays.fill(distance, Integer.MAX_VALUE);
        distance[k] = 0;
        PriorityQueue<int[]> queue = new PriorityQueue<>((a, b) -> Integer.compare(a[0], b[0]));
        queue.add(new int[] {0, k});
        while (!queue.isEmpty()) {
            int[] cell = queue.poll();
            int cost = cell[0];
            int node = cell[1];
            if (cost != distance[node]) {
                continue;
            }
            for (int[] edge : graph.get(node)) {
                int next = cost + edge[1];
                if (next < distance[edge[0]]) {
                    distance[edge[0]] = next;
                    queue.add(new int[] {next, edge[0]});
                }
            }
        }

        int answer = 0;
        for (int node = 1; node <= n; node++) {
            answer = Math.max(answer, distance[node]);
        }
        return answer == Integer.MAX_VALUE ? -1 : answer;
    }
}

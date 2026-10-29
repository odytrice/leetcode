import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.PriorityQueue;

/** O(edges log nodes) time. Dijkstra from the source; the answer is the farthest arrival. */
class ReferenceSolution extends Solution {
    @Override
    public int networkDelayTime(int[][] times, int n, int k) {
        // graph[u] holds {v, time} pairs; nodes are numbered from 1, so index 0 is unused.
        List<List<int[]>> graph = new ArrayList<>();
        for (int node = 0; node <= n; node += 1) {
            graph.add(new ArrayList<>());
        }
        for (int[] edge : times) {
            graph.get(edge[0]).add(new int[] {edge[1], edge[2]});
        }

        // distance[v] is the fastest known arrival time at v; MAX_VALUE means not reached yet.
        int[] distance = new int[n + 1];
        Arrays.fill(distance, Integer.MAX_VALUE);
        distance[k] = 0;
        // Queue entries are {time, node}, earliest time first.
        PriorityQueue<int[]> queue = new PriorityQueue<>((a, b) -> Integer.compare(a[0], b[0]));
        queue.add(new int[] {0, k});
        while (!queue.isEmpty()) {
            int[] cell = queue.poll();
            int cost = cell[0];
            int node = cell[1];
            // A faster route to this node was found after this entry was queued, so skip it.
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

        // The signal reaches everyone when the slowest node hears it.
        int answer = 0;
        for (int node = 1; node <= n; node += 1) {
            answer = Math.max(answer, distance[node]);
        }
        // A node still at MAX_VALUE was never reached, which the problem reports as -1.
        return answer == Integer.MAX_VALUE ? -1 : answer;
    }
}

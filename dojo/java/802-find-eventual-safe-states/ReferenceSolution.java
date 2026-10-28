import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(nodes + edges) time. Reverse Kahn's algorithm from terminal nodes. */
class ReferenceSolution extends Solution {
    @Override
    public List<Integer> eventualSafeNodes(int[][] graph) {
        int count = graph.length;
        List<List<Integer>> reverse = new ArrayList<>();
        for (int node = 0; node < count; node++) {
            reverse.add(new ArrayList<>());
        }
        int[] degree = new int[count];
        for (int node = 0; node < count; node++) {
            degree[node] = graph[node].length;
            for (int target : graph[node]) {
                reverse.get(target).add(node);
            }
        }

        Deque<Integer> queue = new ArrayDeque<>();
        for (int node = 0; node < count; node++) {
            if (degree[node] == 0) {
                queue.add(node);
            }
        }
        while (!queue.isEmpty()) {
            int node = queue.poll();
            for (int source : reverse.get(node)) {
                if (--degree[source] == 0) {
                    queue.add(source);
                }
            }
        }

        List<Integer> result = new ArrayList<>();
        for (int node = 0; node < count; node++) {
            if (degree[node] == 0) {
                result.add(node);
            }
        }
        return result;
    }
}

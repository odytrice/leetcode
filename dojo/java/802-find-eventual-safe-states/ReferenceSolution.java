import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(nodes + edges) time. Reverse Kahn's algorithm from terminal nodes. */
class ReferenceSolution extends Solution {
    @Override
    public List<Integer> eventualSafeNodes(int[][] graph) {
        int count = graph.length;
        // reverse[t] lists the nodes with an edge into t; degree[n] counts n's outgoing edges.
        List<List<Integer>> reverse = new ArrayList<>();
        for (int node = 0; node < count; node += 1) {
            reverse.add(new ArrayList<>());
        }
        int[] degree = new int[count];
        for (int node = 0; node < count; node += 1) {
            degree[node] = graph[node].length;
            for (int target : graph[node]) {
                reverse.get(target).add(node);
            }
        }

        // Terminal nodes have no outgoing edges and are safe by definition.
        Deque<Integer> queue = new ArrayDeque<>();
        for (int node = 0; node < count; node += 1) {
            if (degree[node] == 0) {
                queue.add(node);
            }
        }
        while (!queue.isEmpty()) {
            int node = queue.poll();
            // Each source loses one edge that is known to lead somewhere safe.
            for (int source : reverse.get(node)) {
                degree[source] -= 1;
                // Every edge of source now leads to safety, so source is safe too.
                if (degree[source] == 0) {
                    queue.add(source);
                }
            }
        }

        // Nodes on or leading into a cycle keep a positive degree; the rest are safe, in order.
        List<Integer> result = new ArrayList<>();
        for (int node = 0; node < count; node += 1) {
            if (degree[node] == 0) {
                result.add(node);
            }
        }
        return result;
    }
}

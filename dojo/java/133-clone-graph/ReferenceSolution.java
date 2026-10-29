import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.HashMap;
import java.util.Map;

/** O(nodes + edges) time. Copies each node once, then relinks its neighbours. */
class ReferenceSolution extends Solution {
    @Override
    public GraphNode cloneGraph(GraphNode node) {
        if (node == null) {
            return null;
        }
        // copies maps each original node to its clone and doubles as the visited set.
        Map<GraphNode, GraphNode> copies = new HashMap<>();
        copies.put(node, new GraphNode(node.val));
        Deque<GraphNode> queue = new ArrayDeque<>();
        queue.add(node);
        while (!queue.isEmpty()) {
            GraphNode original = queue.poll();
            for (GraphNode neighbor : original.neighbors) {
                // Clone a neighbour the first time it is seen, and queue it so its edges get copied.
                if (!copies.containsKey(neighbor)) {
                    copies.put(neighbor, new GraphNode(neighbor.val));
                    queue.add(neighbor);
                }
                // Link clone to clone, never clone to original.
                copies.get(original).neighbors.add(copies.get(neighbor));
            }
        }
        return copies.get(node);
    }
}

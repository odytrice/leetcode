import java.util.ArrayList;
import java.util.List;

/** O(n) time. Peels leaves layer by layer; the last one or two nodes are the centres. */
class ReferenceSolution extends Solution {
    @Override
    public List<Integer> findMinHeightTrees(int n, int[][] edges) {
        // A single node has no edges and no leaves, but it is its own centre.
        if (n == 1) {
            return List.of(0);
        }
        // Build an undirected adjacency list and count each node's neighbours.
        List<List<Integer>> graph = new ArrayList<>();
        for (int node = 0; node < n; node += 1) {
            graph.add(new ArrayList<>());
        }
        int[] degree = new int[n];
        for (int[] edge : edges) {
            graph.get(edge[0]).add(edge[1]);
            graph.get(edge[1]).add(edge[0]);
            degree[edge[0]] += 1;
            degree[edge[1]] += 1;
        }

        // The first layer to peel is every node with a single neighbour.
        List<Integer> leaves = new ArrayList<>();
        for (int node = 0; node < n; node += 1) {
            if (degree[node] == 1) {
                leaves.add(node);
            }
        }
        // A tree has at most two centres, so stop once two or fewer nodes remain.
        int remaining = n;
        while (remaining > 2) {
            remaining -= leaves.size();
            List<Integer> nextLeaves = new ArrayList<>();
            for (int leaf : leaves) {
                // Removing the leaf may turn its neighbour into a leaf of the next layer.
                for (int neighbor : graph.get(leaf)) {
                    degree[neighbor] -= 1;
                    if (degree[neighbor] == 1) {
                        nextLeaves.add(neighbor);
                    }
                }
            }
            leaves = nextLeaves;
        }
        leaves.sort(null);
        return leaves;
    }
}

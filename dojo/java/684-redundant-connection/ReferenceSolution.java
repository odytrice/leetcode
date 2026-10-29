/** O(n) time. Unions each edge; the first edge inside one component is the extra one. */
class ReferenceSolution extends Solution {
    // parent[x] points toward x's set representative; a root points to itself.
    private int[] parent;

    @Override
    public int[] findRedundantConnection(int[][] edges) {
        // Nodes are numbered from 1, so size the array one larger.
        parent = new int[edges.length + 1];
        for (int node = 0; node < parent.length; node += 1) {
            parent[node] = node;
        }
        for (int[] edge : edges) {
            int first = find(edge[0]);
            int second = find(edge[1]);
            // Both ends are already connected, so this edge closes a cycle.
            if (first == second) {
                return edge;
            }
            parent[first] = second;
        }
        throw new IllegalArgumentException("No redundant edge");
    }

    private int find(int node) {
        while (parent[node] != node) {
            // Path halving: point at the grandparent so later lookups are shorter.
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}

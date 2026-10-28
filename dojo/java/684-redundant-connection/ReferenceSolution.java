/** O(n) time. Unions each edge; the first edge inside one component is the extra one. */
class ReferenceSolution extends Solution {
    private int[] parent;

    @Override
    public int[] findRedundantConnection(int[][] edges) {
        parent = new int[edges.length + 1];
        for (int node = 0; node < parent.length; node++) {
            parent[node] = node;
        }
        for (int[] edge : edges) {
            int first = find(edge[0]);
            int second = find(edge[1]);
            if (first == second) {
                return edge;
            }
            parent[first] = second;
        }
        throw new IllegalArgumentException("No redundant edge");
    }

    private int find(int node) {
        while (parent[node] != node) {
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}

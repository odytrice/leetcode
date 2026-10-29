/** O(n^2) time. Unions every connected pair and counts the remaining components. */
class ReferenceSolution extends Solution {
    // parent[x] points toward x's set representative; a root points to itself.
    private int[] parent;

    @Override
    public int findCircleNum(int[][] isConnected) {
        int count = isConnected.length;
        // Every city starts as its own province.
        parent = new int[count];
        for (int node = 0; node < count; node += 1) {
            parent[node] = node;
        }
        int components = count;
        // The matrix is symmetric, so checking pairs above the diagonal is enough.
        for (int first = 0; first < count; first += 1) {
            for (int second = first + 1; second < count; second += 1) {
                if (isConnected[first][second] != 1) {
                    continue;
                }
                int rootFirst = find(first);
                int rootSecond = find(second);
                // Joining two different sets merges two provinces into one.
                if (rootFirst != rootSecond) {
                    parent[rootFirst] = rootSecond;
                    components -= 1;
                }
            }
        }
        return components;
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

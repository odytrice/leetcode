/** O(n^2) time. Unions every connected pair and counts the remaining components. */
class ReferenceSolution extends Solution {
    private int[] parent;

    @Override
    public int findCircleNum(int[][] isConnected) {
        int count = isConnected.length;
        parent = new int[count];
        for (int node = 0; node < count; node++) {
            parent[node] = node;
        }
        int components = count;
        for (int first = 0; first < count; first++) {
            for (int second = first + 1; second < count; second++) {
                if (isConnected[first][second] != 1) {
                    continue;
                }
                int rootFirst = find(first);
                int rootSecond = find(second);
                if (rootFirst != rootSecond) {
                    parent[rootFirst] = rootSecond;
                    components--;
                }
            }
        }
        return components;
    }

    private int find(int node) {
        while (parent[node] != node) {
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}

public class ReferenceSolution : Solution
{
    // O(n^2 * alpha(n)) time. Union-find; every successful union merges two provinces.
    public override int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length;
        // Start with every city in its own province.
        int count = n;
        var parent = Enumerable.Range(0, n).ToArray();

        // Path halving keeps the trees shallow.
        int Find(int x)
        {
            while (parent[x] != x)
            {
                parent[x] = parent[parent[x]];
                x = parent[x];
            }
            return x;
        }

        for (int i = 0; i < n; i += 1)
        {
            // The matrix is symmetric, so checking j > i is enough.
            for (int j = i + 1; j < n; j += 1)
            {
                if (isConnected[i][j] != 1)
                {
                    continue;
                }
                int a = Find(i);
                int b = Find(j);
                // Different roots: merge the groups, which removes one province.
                if (a != b)
                {
                    parent[a] = b;
                    count -= 1;
                }
            }
        }
        return count;
    }
}

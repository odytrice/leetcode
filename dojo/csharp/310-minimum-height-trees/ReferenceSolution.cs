public class ReferenceSolution : Solution
{
    // O(n) time. Peel leaves layer by layer; the last one or two nodes are the centers.
    public override IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        // A single node has no edges and no leaves, so it is its own center.
        if (n == 1)
        {
            return new[] { 0 };
        }
        var graph = Enumerable.Range(0, n).Select(_ => new List<int>()).ToArray();
        var degree = new int[n];
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
            degree[e[0]] += 1;
            degree[e[1]] += 1;
        }
        // Start with the outer layer of leaves.
        var leaves = new Queue<int>(Enumerable.Range(0, n).Where(i => degree[i] == 1));
        int remaining = n;
        while (remaining > 2)
        {
            // Remove one whole layer of leaves at a time.
            int count = leaves.Count;
            remaining -= count;
            for (int i = 0; i < count; i += 1)
            {
                int leaf = leaves.Dequeue();
                foreach (int v in graph[leaf])
                {
                    degree[v] -= 1;
                    // A neighbor left with one edge becomes a leaf of the next layer.
                    if (degree[v] == 1)
                    {
                        leaves.Enqueue(v);
                    }
                }
            }
        }
        // At most two nodes remain, and they are the roots of the shortest trees.
        return leaves.ToList();
    }
}

public class ReferenceSolution : Solution
{
    // O(n) time. Peel leaves layer by layer; the last one or two nodes are the centers.
    public override IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
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
        var leaves = new Queue<int>(Enumerable.Range(0, n).Where(i => degree[i] == 1));
        int remaining = n;
        while (remaining > 2)
        {
            int count = leaves.Count;
            remaining -= count;
            for (int i = 0; i < count; i += 1)
            {
                int leaf = leaves.Dequeue();
                foreach (int v in graph[leaf])
                {
                    degree[v] -= 1;
                    if (degree[v] == 1)
                    {
                        leaves.Enqueue(v);
                    }
                }
            }
        }
        return leaves.ToList();
    }
}

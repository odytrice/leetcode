public class ReferenceSolution : Solution
{
    // O(V + E) time. Reverse the edges and peel off nodes whose every path ends at a terminal node.
    public override IList<int> EventualSafeNodes(int[][] graph)
    {
        int n = graph.Length;
        var reverse = Enumerable.Range(0, n).Select(_ => new List<int>()).ToArray();
        // degree[u] counts u's outgoing edges not yet known to lead somewhere safe.
        var degree = new int[n];
        for (int u = 0; u < n; u += 1)
        {
            degree[u] = graph[u].Length;
            foreach (int v in graph[u])
            {
                reverse[v].Add(u);
            }
        }
        var queue = new Queue<int>(Enumerable.Range(0, n).Where(i => degree[i] == 0));
        while (queue.TryDequeue(out int v))
        {
            foreach (int u in reverse[v])
            {
                degree[u] -= 1;
                if (degree[u] == 0)
                {
                    queue.Enqueue(u);
                }
            }
        }
        return Enumerable.Range(0, n).Where(i => degree[i] == 0).ToList();
    }
}

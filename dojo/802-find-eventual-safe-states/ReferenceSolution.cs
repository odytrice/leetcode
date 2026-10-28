public class ReferenceSolution : Solution
{
    public override IList<int> EventualSafeNodes(int[][] graph)
    {
        int n = graph.Length; var reverse = Enumerable.Range(0, n).Select(_ => new List<int>()).ToArray(); var degree = new int[n];
        for (int u = 0; u < n; u++) { degree[u] = graph[u].Length; foreach (int v in graph[u]) reverse[v].Add(u); }
        var queue = new Queue<int>(Enumerable.Range(0, n).Where(i => degree[i] == 0));
        while (queue.TryDequeue(out int v)) foreach (int u in reverse[v]) if (--degree[u] == 0) queue.Enqueue(u);
        return Enumerable.Range(0, n).Where(i => degree[i] == 0).ToList();
    }
}

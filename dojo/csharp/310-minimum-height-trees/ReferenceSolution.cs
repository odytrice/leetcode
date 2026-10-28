public class ReferenceSolution : Solution
{
    public override IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1) return new[] { 0 };
        var graph = Enumerable.Range(0, n).Select(_ => new List<int>()).ToArray(); var degree = new int[n];
        foreach (var e in edges) { graph[e[0]].Add(e[1]); graph[e[1]].Add(e[0]); degree[e[0]]++; degree[e[1]]++; }
        var leaves = new Queue<int>(Enumerable.Range(0, n).Where(i => degree[i] == 1)); int remaining = n;
        while (remaining > 2)
        {
            int count = leaves.Count; remaining -= count;
            while (count-- > 0) { int leaf = leaves.Dequeue(); foreach (int v in graph[leaf]) if (--degree[v] == 1) leaves.Enqueue(v); }
        }
        return leaves.ToList();
    }
}

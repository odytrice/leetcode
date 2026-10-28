public class ReferenceSolution : Solution
{
    public override int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        var edges = Enumerable.Range(0, numCourses).Select(_ => new List<int>()).ToArray(); var degree = new int[numCourses];
        foreach (var p in prerequisites) { edges[p[1]].Add(p[0]); degree[p[0]]++; }
        var queue = new Queue<int>(Enumerable.Range(0, numCourses).Where(i => degree[i] == 0)); var order = new List<int>();
        while (queue.TryDequeue(out int c)) { order.Add(c); foreach (int next in edges[c]) if (--degree[next] == 0) queue.Enqueue(next); }
        return order.Count == numCourses ? order.ToArray() : [];
    }
}

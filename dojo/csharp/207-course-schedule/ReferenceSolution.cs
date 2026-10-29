public class ReferenceSolution : Solution
{
    // O(V + E) time. Kahn's algorithm: every course gets taken only if there is no cycle.
    public override bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var edges = Enumerable.Range(0, numCourses).Select(_ => new List<int>()).ToArray();
        var degree = new int[numCourses];
        foreach (var p in prerequisites)
        {
            edges[p[1]].Add(p[0]);
            degree[p[0]] += 1;
        }
        var queue = new Queue<int>(Enumerable.Range(0, numCourses).Where(i => degree[i] == 0));
        int done = 0;
        while (queue.TryDequeue(out int c))
        {
            done += 1;
            foreach (int next in edges[c])
            {
                degree[next] -= 1;
                if (degree[next] == 0)
                {
                    queue.Enqueue(next);
                }
            }
        }
        return done == numCourses;
    }
}

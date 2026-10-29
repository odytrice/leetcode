public class ReferenceSolution : Solution
{
    // O(V + E) time. Kahn's algorithm: every course gets taken only if there is no cycle.
    public override bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // edges[a] lists the courses that each have a as a prerequisite; degree counts unmet ones.
        var edges = Enumerable.Range(0, numCourses).Select(_ => new List<int>()).ToArray();
        var degree = new int[numCourses];
        foreach (var p in prerequisites)
        {
            edges[p[1]].Add(p[0]);
            degree[p[0]] += 1;
        }
        // Start with the courses that have no prerequisites.
        var queue = new Queue<int>(Enumerable.Range(0, numCourses).Where(i => degree[i] == 0));
        int done = 0;
        while (queue.TryDequeue(out int c))
        {
            done += 1;
            foreach (int next in edges[c])
            {
                degree[next] -= 1;
                // The last prerequisite of next is done, so it can be taken now.
                if (degree[next] == 0)
                {
                    queue.Enqueue(next);
                }
            }
        }
        // Courses on a cycle never reach degree 0, so they are never taken.
        return done == numCourses;
    }
}

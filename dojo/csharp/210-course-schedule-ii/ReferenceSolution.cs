public class ReferenceSolution : Solution
{
    // O(V + E) time. Kahn's algorithm; leftover courses mean a cycle.
    public override int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        // edges[a] lists the courses that each have a as a prerequisite; degree counts unmet ones.
        var edges = Enumerable.Range(0, numCourses).Select(_ => new List<int>()).ToArray();
        var degree = new int[numCourses];
        foreach (var p in prerequisites)
        {
            edges[p[1]].Add(p[0]);
            degree[p[0]] += 1;
        }
        // Courses without prerequisites can be taken first.
        var queue = new Queue<int>(Enumerable.Range(0, numCourses).Where(i => degree[i] == 0));
        var order = new List<int>();
        while (queue.TryDequeue(out int c))
        {
            // A course is dequeued only after all its prerequisites, so this order is valid.
            order.Add(c);
            foreach (int next in edges[c])
            {
                degree[next] -= 1;
                if (degree[next] == 0)
                {
                    queue.Enqueue(next);
                }
            }
        }
        // A short order means some courses sit on a cycle, so no order exists.
        return order.Count == numCourses ? order.ToArray() : [];
    }
}

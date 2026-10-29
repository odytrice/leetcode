public class ReferenceSolution : Solution
{
    // O(E log V) time. Dijkstra from k; the answer is the farthest node's distance.
    public override int NetworkDelayTime(int[][] times, int n, int k)
    {
        // graph[u] lists (neighbor, travel time) pairs; nodes are numbered 1 to n.
        var graph = Enumerable.Range(0, n + 1).Select(_ => new List<(int To, int Weight)>()).ToArray();
        foreach (var e in times)
        {
            graph[e[0]].Add((e[1], e[2]));
        }
        var dist = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
        dist[k] = 0;
        var queue = new PriorityQueue<int, int>();
        queue.Enqueue(k, 0);
        while (queue.TryDequeue(out int u, out int cost))
        {
            // Skip stale queue entries.
            if (cost != dist[u])
            {
                continue;
            }
            foreach (var (v, weight) in graph[u])
            {
                // Queue v only when this route beats its best known time.
                if (cost + weight < dist[v])
                {
                    dist[v] = cost + weight;
                    queue.Enqueue(v, dist[v]);
                }
            }
        }
        // Everyone has the signal once the slowest node does; index 0 is unused.
        int answer = dist.Skip(1).Max();
        // int.MaxValue means some node was never reached.
        return answer == int.MaxValue ? -1 : answer;
    }
}

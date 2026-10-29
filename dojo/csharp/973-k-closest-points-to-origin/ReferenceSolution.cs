public class ReferenceSolution : Solution
{
    // O(n log k) time. A max-heap of size k drops the farthest point whenever it overflows.
    public override int[][] KClosest(int[][] points, int k)
    {
        var heap = new PriorityQueue<int[], int>();
        foreach (var p in points)
        {
            // The priority is the negated squared distance, so the farthest point is dequeued first.
            heap.Enqueue(p, -(p[0] * p[0] + p[1] * p[1]));
            // Over k points: drop the farthest, which cannot be among the k closest.
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }
        // Any order is accepted, so the heap's items can be returned as they are.
        return heap.UnorderedItems.Select(item => item.Element).ToArray();
    }
}

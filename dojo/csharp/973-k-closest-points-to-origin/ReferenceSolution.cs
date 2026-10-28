public class ReferenceSolution : Solution
{
    public override int[][] KClosest(int[][] points, int k)
    {
        var heap = new PriorityQueue<int[], int>();
        foreach (var p in points) { heap.Enqueue(p, -(p[0] * p[0] + p[1] * p[1])); if (heap.Count > k) heap.Dequeue(); }
        return heap.UnorderedItems.Select(item => item.Element).ToArray();
    }
}

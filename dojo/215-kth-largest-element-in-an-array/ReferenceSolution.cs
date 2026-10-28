public class ReferenceSolution : Solution
{
    public override int FindKthLargest(int[] nums, int k)
    {
        var heap = new PriorityQueue<int, int>();
        foreach (int n in nums) { heap.Enqueue(n, n); if (heap.Count > k) heap.Dequeue(); }
        return heap.Peek();
    }
}

public class ReferenceSolution : Solution
{
    // O(n log k) time. A min-heap of the k largest values; its top is the answer.
    public override int FindKthLargest(int[] nums, int k)
    {
        var heap = new PriorityQueue<int, int>();
        foreach (int n in nums)
        {
            heap.Enqueue(n, n);
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }
        return heap.Peek();
    }
}

public class ReferenceSolution : Solution
{
    // O(n log n) time. Always smash the two heaviest stones.
    public override int LastStoneWeight(int[] stones)
    {
        // Negative priorities turn the min-heap into a max-heap.
        var heap = new PriorityQueue<int, int>();
        foreach (int w in stones)
        {
            heap.Enqueue(w, -w);
        }
        while (heap.Count > 1)
        {
            int a = heap.Dequeue();
            int b = heap.Dequeue();
            if (a != b)
            {
                heap.Enqueue(a - b, b - a);
            }
        }
        return heap.Count == 0 ? 0 : heap.Dequeue();
    }
}

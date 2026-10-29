public class ReferenceSolution : MedianFinder
{
    // O(log n) per add, O(1) per median. A max-heap holds the lower half, a min-heap the upper half.
    private readonly PriorityQueue<int, int> lower = new();
    private readonly PriorityQueue<int, int> upper = new();

    public override void AddNum(int num)
    {
        // Pass every value through the lower half so the halves stay ordered.
        lower.Enqueue(num, -num);
        int moved = lower.Dequeue();
        upper.Enqueue(moved, moved);
        // Keep the lower half the same size as the upper half, or one larger.
        if (upper.Count > lower.Count)
        {
            moved = upper.Dequeue();
            lower.Enqueue(moved, -moved);
        }
    }

    public override double FindMedian()
    {
        if (lower.Count > upper.Count)
        {
            return lower.Peek();
        }
        return ((long)lower.Peek() + upper.Peek()) / 2.0;
    }
}

public class ReferenceSolution : MedianFinder
{
    private readonly PriorityQueue<int, int> lower = new(), upper = new();
    public override void AddNum(int num)
    {
        lower.Enqueue(num, -num);
        int moved = lower.Dequeue(); upper.Enqueue(moved, moved);
        if (upper.Count > lower.Count) { moved = upper.Dequeue(); lower.Enqueue(moved, -moved); }
    }
    public override double FindMedian() => lower.Count > upper.Count ? lower.Peek() : ((long)lower.Peek() + upper.Peek()) / 2.0;
}

public class ReferenceSolution : MinStack
{
    // O(1) per operation. Each entry remembers the minimum at the time it was pushed.
    private readonly Stack<(int Value, int Min)> stack = new();

    public override void Push(int val)
    {
        // The new minimum is the smaller of this value and the minimum below it.
        int min = stack.Count == 0 ? val : Math.Min(val, stack.Peek().Min);
        stack.Push((val, min));
    }

    public override void Pop()
    {
        // Popping also drops its minimum, which restores the one below.
        stack.Pop();
    }

    public override int Top()
    {
        return stack.Peek().Value;
    }

    public override int GetMin()
    {
        // The top entry already knows the minimum of the whole stack.
        return stack.Peek().Min;
    }
}

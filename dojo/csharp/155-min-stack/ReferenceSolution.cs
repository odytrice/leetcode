public class ReferenceSolution : MinStack
{
    // O(1) per operation. Each entry remembers the minimum at the time it was pushed.
    private readonly Stack<(int Value, int Min)> stack = new();

    public override void Push(int val)
    {
        int min = stack.Count == 0 ? val : Math.Min(val, stack.Peek().Min);
        stack.Push((val, min));
    }

    public override void Pop()
    {
        stack.Pop();
    }

    public override int Top()
    {
        return stack.Peek().Value;
    }

    public override int GetMin()
    {
        return stack.Peek().Min;
    }
}

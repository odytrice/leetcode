public class ReferenceSolution : MinStack
{
    private readonly Stack<(int Value, int Min)> stack = new();
    public override void Push(int val) => stack.Push((val, stack.Count == 0 ? val : Math.Min(val, stack.Peek().Min)));
    public override void Pop() => stack.Pop();
    public override int Top() => stack.Peek().Value;
    public override int GetMin() => stack.Peek().Min;
}

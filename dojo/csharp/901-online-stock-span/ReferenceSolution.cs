public class ReferenceSolution : StockSpanner
{
    // Amortized O(1). A monotonic stack folds each lower-or-equal price's span into the new one.
    private readonly Stack<(int Price, int Span)> stack = new();

    public override int Next(int price)
    {
        int span = 1;
        while (stack.Count > 0 && stack.Peek().Price <= price)
        {
            span += stack.Pop().Span;
        }
        stack.Push((price, span));
        return span;
    }
}

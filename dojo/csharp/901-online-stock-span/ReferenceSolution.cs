public class ReferenceSolution : StockSpanner
{
    // Amortized O(1). A monotonic stack folds each lower-or-equal price's span into the new one.
    private readonly Stack<(int Price, int Span)> stack = new();

    public override int Next(int price)
    {
        // Today's span counts today itself.
        int span = 1;
        while (stack.Count > 0 && stack.Peek().Price <= price)
        {
            // A lower or equal earlier price is covered by today, along with everything it covered.
            span += stack.Pop().Span;
        }
        // The stack keeps prices strictly decreasing from bottom to top.
        stack.Push((price, span));
        return span;
    }
}

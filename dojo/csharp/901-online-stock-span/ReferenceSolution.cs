public class ReferenceSolution : StockSpanner
{
    private readonly Stack<(int Price, int Span)> stack = new();
    public override int Next(int price)
    {
        int span = 1;
        while (stack.Count > 0 && stack.Peek().Price <= price) span += stack.Pop().Span;
        stack.Push((price, span));
        return span;
    }
}

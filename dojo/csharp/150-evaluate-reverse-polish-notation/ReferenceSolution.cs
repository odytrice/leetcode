public class ReferenceSolution : Solution
{
    // O(n) time. Numbers wait on a stack until an operator consumes the top two.
    public override int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (string token in tokens)
        {
            // Anything that parses as a number is an operand; the rest are operators.
            if (int.TryParse(token, out int n))
            {
                stack.Push(n);
                continue;
            }
            // The right operand is on top.
            int b = stack.Pop();
            int a = stack.Pop();
            int value = token switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                // C# integer division truncates toward zero, as the problem requires.
                "/" => a / b,
                _ => throw new ArgumentException(),
            };
            // The result becomes an operand for a later operator.
            stack.Push(value);
        }
        // A valid expression leaves exactly one value.
        return stack.Pop();
    }
}

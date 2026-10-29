public class ReferenceSolution : Solution
{
    // O(n) time. Numbers wait on a stack until an operator consumes the top two.
    public override int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (string token in tokens)
        {
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
                "/" => a / b,
                _ => throw new ArgumentException(),
            };
            stack.Push(value);
        }
        return stack.Pop();
    }
}

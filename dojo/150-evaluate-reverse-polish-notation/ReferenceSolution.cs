public class ReferenceSolution : Solution
{
    public override int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int n)) { stack.Push(n); continue; }
            int b = stack.Pop(), a = stack.Pop();
            stack.Push(token switch { "+" => a + b, "-" => a - b, "*" => a * b, "/" => a / b, _ => throw new ArgumentException() });
        }
        return stack.Pop();
    }
}

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.Set;

/** O(n) time. Pushes operands; each operator consumes the last two. */
class ReferenceSolution extends Solution {
    @Override
    public int evalRPN(String[] tokens) {
        Set<String> operators = Set.of("+", "-", "*", "/");
        // The stack holds values that are waiting for an operator.
        Deque<Integer> stack = new ArrayDeque<>();
        for (String token : tokens) {
            if (!operators.contains(token)) {
                stack.push(Integer.parseInt(token));
                continue;
            }
            // The top of the stack is the right operand, so pop it first; order matters for - and /.
            int right = stack.pop();
            int left = stack.pop();
            switch (token) {
                case "+" -> stack.push(left + right);
                case "-" -> stack.push(left - right);
                case "*" -> stack.push(left * right);
                default -> stack.push(left / right);
            }
        }
        // A valid expression leaves exactly one value: the result.
        return stack.pop();
    }
}

import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. Every closer must match the most recent opener. */
class ReferenceSolution extends Solution {
    @Override
    public boolean isValid(String s) {
        // The stack holds openers that are still waiting for their closer.
        Deque<Character> stack = new ArrayDeque<>();
        for (char letter : s.toCharArray()) {
            switch (letter) {
                case '(':
                case '[':
                case '{':
                    stack.push(letter);
                    break;
                // A closer fails if nothing is open or the latest opener is a different kind.
                case ')':
                    if (stack.isEmpty() || stack.pop() != '(') {
                        return false;
                    }
                    break;
                case ']':
                    if (stack.isEmpty() || stack.pop() != '[') {
                        return false;
                    }
                    break;
                default:
                    if (stack.isEmpty() || stack.pop() != '{') {
                        return false;
                    }
            }
        }
        // Any opener left over was never closed.
        return stack.isEmpty();
    }
}

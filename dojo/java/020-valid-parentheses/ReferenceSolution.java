import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. Every closer must match the most recent opener. */
class ReferenceSolution extends Solution {
    @Override
    public boolean isValid(String s) {
        Deque<Character> stack = new ArrayDeque<>();
        for (char letter : s.toCharArray()) {
            switch (letter) {
                case '(':
                case '[':
                case '{':
                    stack.push(letter);
                    break;
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
        return stack.isEmpty();
    }
}

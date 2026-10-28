import java.util.ArrayDeque;
import java.util.Deque;

/** O(1) per operation. Each entry remembers the minimum at or below it. */
class ReferenceSolution extends MinStack {
    private final Deque<int[]> stack = new ArrayDeque<>();

    @Override
    public void push(int val) {
        int currentMin = stack.isEmpty() ? val : Math.min(val, stack.peek()[1]);
        stack.push(new int[] {val, currentMin});
    }

    @Override
    public void pop() {
        stack.pop();
    }

    @Override
    public int top() {
        return stack.peek()[0];
    }

    @Override
    public int getMin() {
        return stack.peek()[1];
    }
}

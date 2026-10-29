import java.util.ArrayDeque;
import java.util.Deque;

/** Amortized O(1) per call. Drops prices no higher than today's, summing their spans. */
class ReferenceSolution extends StockSpanner {
    // Each entry is {price, span}; prices strictly decrease from bottom to top.
    private final Deque<int[]> stack = new ArrayDeque<>();

    @Override
    public int next(int price) {
        // Today always counts toward its own span.
        int span = 1;
        // A popped price's span covers days it already absorbed, so add it all at once.
        while (!stack.isEmpty() && stack.peek()[0] <= price) {
            span += stack.pop()[1];
        }
        stack.push(new int[] {price, span});
        return span;
    }
}

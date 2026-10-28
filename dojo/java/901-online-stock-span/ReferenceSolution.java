import java.util.ArrayDeque;
import java.util.Deque;

/** Amortized O(1) per call. Drops prices no higher than today's, summing their spans. */
class ReferenceSolution extends StockSpanner {
    private final Deque<int[]> stack = new ArrayDeque<>();

    @Override
    public int next(int price) {
        int span = 1;
        while (!stack.isEmpty() && stack.peek()[0] <= price) {
            span += stack.pop()[1];
        }
        stack.push(new int[] {price, span});
        return span;
    }
}

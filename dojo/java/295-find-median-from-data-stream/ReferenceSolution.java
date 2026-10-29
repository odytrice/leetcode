import java.util.Collections;
import java.util.PriorityQueue;

/** O(log n) insertion, O(1) median. Two heaps keep the middle at the tops. */
class ReferenceSolution extends MedianFinder {
    // lower is a max-heap of the smaller half; upper is a min-heap of the larger half.
    private final PriorityQueue<Integer> lower = new PriorityQueue<>(Collections.reverseOrder());
    private final PriorityQueue<Integer> upper = new PriorityQueue<>();

    @Override
    public void addNum(int num) {
        // Pass the number through lower so the largest small value moves up to upper.
        lower.add(num);
        upper.add(lower.poll());
        // Rebalance so lower always has the same size as upper, or one more.
        if (upper.size() > lower.size()) {
            lower.add(upper.poll());
        }
    }

    @Override
    public double findMedian() {
        // An odd count leaves the extra value on top of lower.
        if (lower.size() > upper.size()) {
            return lower.peek();
        }
        // Widen to long before adding so two large ints cannot overflow.
        return (lower.peek() + (long) upper.peek()) / 2.0;
    }
}

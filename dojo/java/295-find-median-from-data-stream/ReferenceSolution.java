import java.util.Collections;
import java.util.PriorityQueue;

/** O(log n) insertion, O(1) median. Two heaps keep the middle at the tops. */
class ReferenceSolution extends MedianFinder {
    private final PriorityQueue<Integer> lower = new PriorityQueue<>(Collections.reverseOrder());
    private final PriorityQueue<Integer> upper = new PriorityQueue<>();

    @Override
    public void addNum(int num) {
        lower.add(num);
        upper.add(lower.poll());
        if (upper.size() > lower.size()) {
            lower.add(upper.poll());
        }
    }

    @Override
    public double findMedian() {
        if (lower.size() > upper.size()) {
            return lower.peek();
        }
        return (lower.peek() + (long) upper.peek()) / 2.0;
    }
}

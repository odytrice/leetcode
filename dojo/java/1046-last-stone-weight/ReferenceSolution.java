import java.util.Collections;
import java.util.PriorityQueue;

/** O(n log n) time. Always smashes the two heaviest stones. */
class ReferenceSolution extends Solution {
    @Override
    public int lastStoneWeight(int[] stones) {
        // Reverse order turns Java's min-heap into a max-heap, so poll() gives the heaviest.
        PriorityQueue<Integer> heap = new PriorityQueue<>(Collections.reverseOrder());
        for (int stone : stones) {
            heap.add(stone);
        }
        while (heap.size() > 1) {
            int first = heap.poll();
            int second = heap.poll();
            // Equal stones destroy each other; otherwise the leftover goes back in.
            if (first != second) {
                heap.add(first - second);
            }
        }
        // An empty heap means every stone was destroyed.
        return heap.isEmpty() ? 0 : heap.poll();
    }
}

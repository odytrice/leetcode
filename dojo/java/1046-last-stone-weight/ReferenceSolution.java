import java.util.Collections;
import java.util.PriorityQueue;

/** O(n log n) time. Always smashes the two heaviest stones. */
class ReferenceSolution extends Solution {
    @Override
    public int lastStoneWeight(int[] stones) {
        PriorityQueue<Integer> heap = new PriorityQueue<>(Collections.reverseOrder());
        for (int stone : stones) {
            heap.add(stone);
        }
        while (heap.size() > 1) {
            int first = heap.poll();
            int second = heap.poll();
            if (first != second) {
                heap.add(first - second);
            }
        }
        return heap.isEmpty() ? 0 : heap.poll();
    }
}

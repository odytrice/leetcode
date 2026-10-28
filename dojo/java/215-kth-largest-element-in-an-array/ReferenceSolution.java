import java.util.PriorityQueue;

/** O(n log k) time. Keeps a min-heap of the k largest values. */
class ReferenceSolution extends Solution {
    @Override
    public int findKthLargest(int[] nums, int k) {
        PriorityQueue<Integer> heap = new PriorityQueue<>();
        for (int value : nums) {
            heap.add(value);
            if (heap.size() > k) {
                heap.poll();
            }
        }
        return heap.peek();
    }
}

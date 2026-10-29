import java.util.PriorityQueue;

/** O(n log k) time. Keeps a min-heap of the k largest values. */
class ReferenceSolution extends Solution {
    @Override
    public int findKthLargest(int[] nums, int k) {
        // A min-heap capped at k keeps the k largest values, with the smallest of them on top.
        PriorityQueue<Integer> heap = new PriorityQueue<>();
        for (int value : nums) {
            heap.add(value);
            // Too many values: drop the smallest, which cannot be in the top k.
            if (heap.size() > k) {
                heap.poll();
            }
        }
        // The smallest of the k largest is the kth largest.
        return heap.peek();
    }
}

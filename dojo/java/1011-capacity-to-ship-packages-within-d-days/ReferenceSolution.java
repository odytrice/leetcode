/** O(n log total weight) time. The capacity must fit the heaviest package. */
class ReferenceSolution extends Solution {
    @Override
    public int shipWithinDays(int[] weights, int days) {
        int left = 0;
        int right = 0;
        for (int weight : weights) {
            left = Math.max(left, weight);
            right += weight;
        }
        while (left < right) {
            int capacity = (left + right) / 2;
            int used = 1;
            int load = 0;
            for (int weight : weights) {
                if (load + weight > capacity) {
                    used++;
                    load = 0;
                }
                load += weight;
            }
            if (used <= days) {
                right = capacity;
            } else {
                left = capacity + 1;
            }
        }
        return left;
    }
}

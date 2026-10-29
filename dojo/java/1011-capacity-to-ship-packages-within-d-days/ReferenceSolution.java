/** O(n log total weight) time. The capacity must fit the heaviest package. */
class ReferenceSolution extends Solution {
    @Override
    public int shipWithinDays(int[] weights, int days) {
        // The answer lies between the heaviest package and the total weight (one day).
        int left = 0;
        int right = 0;
        for (int weight : weights) {
            left = Math.max(left, weight);
            right += weight;
        }
        // Binary search the smallest capacity that still finishes within the days allowed.
        while (left < right) {
            int capacity = (left + right) / 2;
            // Simulate loading greedily: start a new day when the next package does not fit.
            int used = 1;
            int load = 0;
            for (int weight : weights) {
                if (load + weight > capacity) {
                    used += 1;
                    load = 0;
                }
                load += weight;
            }
            // This capacity works, so keep it as a candidate and try smaller ones.
            if (used <= days) {
                right = capacity;
            } else {
                left = capacity + 1;
            }
        }
        return left;
    }
}

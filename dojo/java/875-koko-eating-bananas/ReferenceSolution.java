/** O(n log max(piles)) time. Binary searches the smallest speed that finishes in time. */
class ReferenceSolution extends Solution {
    @Override
    public int minEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = 0;
        for (int pile : piles) {
            right = Math.max(right, pile);
        }
        while (left < right) {
            int speed = (left + right) / 2;
            long hours = 0;
            for (int pile : piles) {
                hours += (pile + (long) speed - 1) / speed;
            }
            if (hours <= h) {
                right = speed;
            } else {
                left = speed + 1;
            }
        }
        return left;
    }
}

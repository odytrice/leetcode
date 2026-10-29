/** O(n log max(piles)) time. Binary searches the smallest speed that finishes in time. */
class ReferenceSolution extends Solution {
    @Override
    public int minEatingSpeed(int[] piles, int h) {
        // The speed lies between 1 and the biggest pile; faster than that never saves time.
        int left = 1;
        int right = 0;
        for (int pile : piles) {
            right = Math.max(right, pile);
        }
        while (left < right) {
            int speed = (left + right) / 2;
            // Each pile takes ceil(pile / speed) hours; long avoids overflow in the sum.
            long hours = 0;
            for (int pile : piles) {
                hours += (pile + (long) speed - 1) / speed;
            }
            // Fast enough: keep this speed as a candidate and look for a slower one.
            if (hours <= h) {
                right = speed;
            } else {
                left = speed + 1;
            }
        }
        return left;
    }
}

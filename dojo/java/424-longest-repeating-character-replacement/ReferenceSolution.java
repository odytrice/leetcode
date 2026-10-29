/** O(n) time. A window is valid when everything but its most common letter fits in k. */
class ReferenceSolution extends Solution {
    @Override
    public int characterReplacement(String s, int k) {
        // counts[c] is how often letter c appears in the window s[left..right].
        int[] counts = new int[26];
        int left = 0;
        int best = 0;
        // most is the highest count seen; it never needs to drop, since only a higher count can beat best.
        int most = 0;
        for (int right = 0; right < s.length(); right += 1) {
            int index = s.charAt(right) - 'A';
            counts[index] += 1;
            most = Math.max(most, counts[index]);
            // Too many letters would need replacing, so shrink from the left.
            while (right - left + 1 - most > k) {
                counts[s.charAt(left) - 'A'] -= 1;
                left += 1;
            }
            best = Math.max(best, right - left + 1);
        }
        return best;
    }
}

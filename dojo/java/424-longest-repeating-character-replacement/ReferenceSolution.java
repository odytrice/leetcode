/** O(n) time. A window is valid when everything but its most common letter fits in k. */
class ReferenceSolution extends Solution {
    @Override
    public int characterReplacement(String s, int k) {
        int[] counts = new int[26];
        int left = 0;
        int best = 0;
        int most = 0;
        for (int right = 0; right < s.length(); right += 1) {
            int index = s.charAt(right) - 'A';
            counts[index] += 1;
            most = Math.max(most, counts[index]);
            while (right - left + 1 - most > k) {
                counts[s.charAt(left) - 'A'] -= 1;
                left += 1;
            }
            best = Math.max(best, right - left + 1);
        }
        return best;
    }
}

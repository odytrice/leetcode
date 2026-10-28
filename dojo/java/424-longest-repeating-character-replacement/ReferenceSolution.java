/** O(n) time. A window is valid when everything but its most common letter fits in k. */
class ReferenceSolution extends Solution {
    @Override
    public int characterReplacement(String s, int k) {
        int[] counts = new int[26];
        int left = 0;
        int best = 0;
        int most = 0;
        for (int right = 0; right < s.length(); right++) {
            int index = s.charAt(right) - 'A';
            most = Math.max(most, ++counts[index]);
            while (right - left + 1 - most > k) {
                counts[s.charAt(left++) - 'A']--;
            }
            best = Math.max(best, right - left + 1);
        }
        return best;
    }
}

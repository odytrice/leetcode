import java.util.HashMap;
import java.util.Map;

/** O(n) time. Each character's last position moves the window's left edge. */
class ReferenceSolution extends Solution {
    @Override
    public int lengthOfLongestSubstring(String s) {
        Map<Character, Integer> last = new HashMap<>();
        int left = 0;
        int best = 0;
        for (int right = 0; right < s.length(); right += 1) {
            Integer previous = last.get(s.charAt(right));
            if (previous != null) {
                left = Math.max(left, previous + 1);
            }
            last.put(s.charAt(right), right);
            best = Math.max(best, right - left + 1);
        }
        return best;
    }
}

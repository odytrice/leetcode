import java.util.ArrayList;
import java.util.List;

/** O(n) time. A part ends only when no letter in it appears later. */
class ReferenceSolution extends Solution {
    @Override
    public List<Integer> partitionLabels(String s) {
        // last[c] is the final index where letter c appears.
        int[] last = new int[26];
        for (int index = 0; index < s.length(); index += 1) {
            last[s.charAt(index) - 'a'] = index;
        }
        List<Integer> result = new ArrayList<>();
        int start = 0;
        // end is the furthest last-occurrence of any letter in the current part.
        int end = 0;
        for (int index = 0; index < s.length(); index += 1) {
            end = Math.max(end, last[s.charAt(index) - 'a']);
            // Reaching end means every letter in this part is finished, so close it here.
            if (index == end) {
                result.add(end - start + 1);
                start = index + 1;
            }
        }
        return result;
    }
}

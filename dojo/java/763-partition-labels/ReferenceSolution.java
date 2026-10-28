import java.util.ArrayList;
import java.util.List;

/** O(n) time. A part ends only when no letter in it appears later. */
class ReferenceSolution extends Solution {
    @Override
    public List<Integer> partitionLabels(String s) {
        int[] last = new int[26];
        for (int index = 0; index < s.length(); index++) {
            last[s.charAt(index) - 'a'] = index;
        }
        List<Integer> result = new ArrayList<>();
        int start = 0;
        int end = 0;
        for (int index = 0; index < s.length(); index++) {
            end = Math.max(end, last[s.charAt(index) - 'a']);
            if (index == end) {
                result.add(end - start + 1);
                start = index + 1;
            }
        }
        return result;
    }
}

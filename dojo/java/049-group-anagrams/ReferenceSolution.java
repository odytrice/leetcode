import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/** O(total characters) time. Letter counts identify each anagram group. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<String>> groupAnagrams(String[] strs) {
        Map<String, List<String>> groups = new HashMap<>();
        for (String word : strs) {
            int[] counts = new int[26];
            for (char letter : word.toCharArray()) {
                counts[letter - 'a']++;
            }
            groups.computeIfAbsent(Arrays.toString(counts), key -> new ArrayList<>()).add(word);
        }
        return new ArrayList<>(groups.values());
    }
}

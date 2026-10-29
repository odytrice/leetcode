import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(sorted products + prefix searches). Sorts once, then reads three matches per prefix. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<String>> suggestedProducts(String[] products, String searchWord) {
        // Sorted order puts every word sharing a prefix in one block, smallest first.
        String[] ordered = products.clone();
        Arrays.sort(ordered);
        List<List<String>> result = new ArrayList<>();
        for (int length = 1; length <= searchWord.length(); length += 1) {
            String prefix = searchWord.substring(0, length);
            // Binary search for the first word that is not smaller than the prefix.
            int low = 0;
            int high = ordered.length;
            while (low < high) {
                int middle = (low + high) / 2;
                if (ordered[middle].compareTo(prefix) < 0) {
                    low = middle + 1;
                } else {
                    high = middle;
                }
            }
            // Take up to three words from there, stopping once the prefix no longer matches.
            List<String> suggestions = new ArrayList<>();
            for (int index = low; index < ordered.length && suggestions.size() < 3; index += 1) {
                if (!ordered[index].startsWith(prefix)) {
                    break;
                }
                suggestions.add(ordered[index]);
            }
            result.add(suggestions);
        }
        return result;
    }
}

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/** O(sorted products + prefix searches). Sorts once, then reads three matches per prefix. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<String>> suggestedProducts(String[] products, String searchWord) {
        String[] ordered = products.clone();
        Arrays.sort(ordered);
        List<List<String>> result = new ArrayList<>();
        for (int length = 1; length <= searchWord.length(); length++) {
            String prefix = searchWord.substring(0, length);
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
            List<String> suggestions = new ArrayList<>();
            for (int index = low; index < ordered.length && suggestions.size() < 3; index++) {
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

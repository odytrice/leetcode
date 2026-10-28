import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

/** O(total letters) time. Walks a trie of roots and stops at the first word end. */
class ReferenceSolution extends Solution {
    @Override
    public String replaceWords(List<String> dictionary, String sentence) {
        Map<Character, Map> root = new HashMap<>();
        Set<String> words = new HashSet<>(dictionary);
        for (String word : dictionary) {
            Map<Character, Map> node = root;
            for (char letter : word.toCharArray()) {
                node = node.computeIfAbsent(letter, key -> new HashMap<Character, Map>());
            }
        }

        StringBuilder result = new StringBuilder();
        for (String word : sentence.split(" ")) {
            if (result.length() > 0) {
                result.append(' ');
            }
            result.append(replace(root, words, word));
        }
        return result.toString();
    }

    private String replace(Map<Character, Map> root, Set<String> words, String word) {
        Map<Character, Map> node = root;
        StringBuilder prefix = new StringBuilder();
        for (char letter : word.toCharArray()) {
            node = node.get(letter);
            if (node == null) {
                return word;
            }
            prefix.append(letter);
            if (words.contains(prefix.toString())) {
                return prefix.toString();
            }
        }
        return word;
    }
}

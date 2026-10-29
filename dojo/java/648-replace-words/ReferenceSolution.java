import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

/** O(total letters) time. Walks a trie of roots and stops at the first word end. */
class ReferenceSolution extends Solution {
    @Override
    public String replaceWords(List<String> dictionary, String sentence) {
        // A nested-map trie of the roots; words records which paths are complete roots.
        Map<Character, Map> root = new HashMap<>();
        Set<String> words = new HashSet<>(dictionary);
        for (String word : dictionary) {
            Map<Character, Map> node = root;
            for (char letter : word.toCharArray()) {
                node = node.computeIfAbsent(letter, key -> new HashMap<Character, Map>());
            }
        }

        // Replace each word and rejoin them with single spaces.
        StringBuilder result = new StringBuilder();
        for (String word : sentence.split(" ")) {
            if (result.length() > 0) {
                result.append(' ');
            }
            result.append(replace(root, words, word));
        }
        return result.toString();
    }

    // Returns the shortest root that starts word, or word itself if there is none.
    private String replace(Map<Character, Map> root, Set<String> words, String word) {
        Map<Character, Map> node = root;
        StringBuilder prefix = new StringBuilder();
        for (char letter : word.toCharArray()) {
            node = node.get(letter);
            // The trie has no branch for this letter, so no root matches.
            if (node == null) {
                return word;
            }
            prefix.append(letter);
            // Stop at the first complete root, which is the shortest one.
            if (words.contains(prefix.toString())) {
                return prefix.toString();
            }
        }
        return word;
    }
}

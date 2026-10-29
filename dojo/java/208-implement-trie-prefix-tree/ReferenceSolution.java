import java.util.HashMap;
import java.util.Map;

/** O(word length) per operation. Each node maps letters and records word ends. */
class ReferenceSolution extends Trie {
    // A node stands for the prefix spelled by the path from the root to it.
    private static final class Node {
        private final Map<Character, Node> children = new HashMap<>();
        // True when some inserted word ends exactly here, not just passes through.
        private boolean endsWord;
    }

    private final Node root = new Node();

    @Override
    public void insert(String word) {
        // Follow the letters, creating any missing nodes along the way.
        Node node = root;
        for (char letter : word.toCharArray()) {
            node = node.children.computeIfAbsent(letter, key -> new Node());
        }
        node.endsWord = true;
    }

    // Returns the node for the given prefix, or null if no inserted word starts with it.
    private Node find(String text) {
        Node node = root;
        for (char letter : text.toCharArray()) {
            node = node.children.get(letter);
            if (node == null) {
                return null;
            }
        }
        return node;
    }

    @Override
    public boolean search(String word) {
        // The path must exist and also be marked as a complete word.
        Node node = find(word);
        return node != null && node.endsWord;
    }

    @Override
    public boolean startsWith(String prefix) {
        return find(prefix) != null;
    }
}
